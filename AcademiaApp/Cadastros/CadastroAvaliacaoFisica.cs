using AcademiaApp.Base;
using AcademiaDomain;
using AcademiaService.Base;
using AcademiaService.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AcademiaApp.Cadastros
{
    public partial class CadastroAvaliacaoFisica : CadastroBase
    {
        private readonly IBaseService<AvaliacaoFisica> _avaliacaoService;
        private readonly IBaseService<Aluno> _alunoService;
        private List<AvaliacaoFisica> _avaliacoes = new();

        public CadastroAvaliacaoFisica(
            IBaseService<AvaliacaoFisica> avaliacaoService,
            IBaseService<Aluno> alunoService)
        {
            _avaliacaoService = avaliacaoService;
            _alunoService = alunoService;
            InitializeComponent();
            CarregaCombo();
            CarregaGrid();
        }

        private void CarregaCombo()
        {
            cboAluno.DataSource = _alunoService.ReadAll<Aluno>().ToList();
            cboAluno.DisplayMember = "Nome";
            cboAluno.ValueMember = "Id";
        }

        private void PreencheObjeto(AvaliacaoFisica avaliacao)
        {
            if (int.TryParse(cboAluno.SelectedValue?.ToString(), out int alunoId))
            {
                // Carrega o objeto Aluno do banco e atribui diretamente na propriedade Aluno
                avaliacao.Aluno = _alunoService.ReadById<Aluno>(alunoId);
            }

            avaliacao.Peso = double.TryParse(txtPeso.Text, out double peso) ? peso : 0;
            avaliacao.Altura = double.TryParse(txtAltura.Text, out double altura) ? altura : 0;
            avaliacao.PercentualGordura = float.TryParse(txtPercentualGordura.Text, out float bf) ? bf : 0;
            avaliacao.Observacao = txtObservacao.Text;
            avaliacao.DataAvaliacao = DateTime.Now;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var avaliacao = _avaliacaoService.ReadById<AvaliacaoFisica>(id);
                    PreencheObjeto(avaliacao);
                    _avaliacaoService.Update<AvaliacaoFisica, AvaliacaoFisica, AvaliacaoFisicaValidator>(avaliacao);
                }
                else
                {
                    var avaliacao = new AvaliacaoFisica();
                    PreencheObjeto(avaliacao);
                    _avaliacaoService.Create<AvaliacaoFisica, AvaliacaoFisica, AvaliacaoFisicaValidator>(avaliacao);
                }

                TabControlCadastro.SelectedIndex = 1;
                CarregaGrid();
            }
            catch (Exception ex)
            {
                var mensagemErro = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show(mensagemErro, "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _avaliacaoService.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _avaliacoes = _avaliacaoService.ReadAll<AvaliacaoFisica>().ToList();
            var dadosGrid = _avaliacoes.Select(a => new
            {
                a.ID,
                Aluno = a.Aluno != null ? a.Aluno.Nome : "Não informado",
                a.Peso,
                a.Altura,
                PercentualGordura = a.PercentualGordura,
                Data = a.DataAvaliacao,
                a.Observacao
            }).ToList();

            dataGridViewConsulta.DataSource = dadosGrid;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            txtId.Text = row.Cells["Id"].Value?.ToString() ?? row.Cells["ID"].Value?.ToString();
            if (row.DataBoundItem is AvaliacaoFisica avaliacao && avaliacao.Aluno != null)
            {
                cboAluno.SelectedValue = avaliacao.Aluno.ID;
            }
            txtPeso.Text = row.Cells["Peso"].Value?.ToString();
            txtAltura.Text = row.Cells["Altura"].Value?.ToString();
            txtPercentualGordura.Text = row.Cells["PercentualGordura"].Value?.ToString();
        }

    }
}

