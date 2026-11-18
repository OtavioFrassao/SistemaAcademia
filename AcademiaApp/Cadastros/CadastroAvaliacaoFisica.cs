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
            _avaliacoes = _avaliacaoService
                .ReadAll<AvaliacaoFisica>()
                .ToList();

            FiltrarAvaliacoes();
        }

        private void txtPesquisaAvaliacao_TextChanged(object sender, EventArgs e)
        {
            FiltrarAvaliacoes();
        }

        private void FiltrarAvaliacoes()
        {
            string pesquisa = txtPesquisaAvaliacao.Text.Trim();

            var dados = _avaliacoes
                .Where(a =>
                    string.IsNullOrWhiteSpace(pesquisa) ||
                    a.ID.ToString().Contains(pesquisa) ||
                    (a.Aluno?.Nome?.Contains(pesquisa,
                        StringComparison.OrdinalIgnoreCase) ?? false))
                .Select(a => new
                {
                    a.ID,
                    Aluno = a.Aluno?.Nome ?? "Não informado",
                    a.Peso,
                    a.Altura,
                    a.PercentualGordura,
                    Data = a.DataAvaliacao,
                    a.Observacao
                })
                .ToList();

            dataGridViewConsulta.DataSource = null;
            dataGridViewConsulta.AutoGenerateColumns = true;
            dataGridViewConsulta.DataSource = dados;

            dataGridViewConsulta.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewConsulta.Columns["ID"].FillWeight = 10;
            dataGridViewConsulta.Columns["Aluno"].FillWeight = 35;
            dataGridViewConsulta.Columns["Observacao"].FillWeight = 35;

            dataGridViewConsulta.Columns["Data"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";
        }


        protected override void CarregarRegistro(DataGridViewRow row)
        {
            int id = Convert.ToInt32(row.Cells["ID"].Value);

            var avaliacao = _avaliacoes.FirstOrDefault(a => a.ID == id);

            if (avaliacao == null)
                return;

            txtId.Text = avaliacao.ID.ToString();
            cboAluno.SelectedValue = avaliacao.Aluno?.ID;
            txtPeso.Text = avaliacao.Peso.ToString();
            txtAltura.Text = avaliacao.Altura.ToString();
            txtPercentualGordura.Text =
                avaliacao.PercentualGordura.ToString();
            txtObservacao.Text = avaliacao.Observacao;
        }

    }
}

