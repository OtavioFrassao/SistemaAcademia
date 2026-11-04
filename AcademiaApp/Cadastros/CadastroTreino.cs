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
    public partial class CadastroTreino : CadastroBase
    {
        private readonly IBaseService<Treino> _treinoService;
        private readonly IBaseService<Aluno> _alunoService;
        private List<Treino> _treinos = new();

        public CadastroTreino(
            IBaseService<Treino> treinoService,
            IBaseService<Aluno> alunoService)
        {
            _treinoService = treinoService;
            _alunoService = alunoService;
            InitializeComponent();

            txtDataInicio.Mask = "00/00/0000";
            txtDataFim.Mask = "00/00/0000";

            CarregaCombo();
            CarregaGrid();
        }

        private void CarregaCombo()
        {
            cboAluno.DataSource = _alunoService.ReadAll<Aluno>().ToList();
            cboAluno.DisplayMember = "Nome";
            cboAluno.ValueMember = "ID";
        }

        private void PreencheObjeto(Treino treino)
        {
            if (cboAluno.SelectedItem is Aluno alunoSelecionado)
            {
                treino.Aluno = _alunoService.ReadById<Aluno>(alunoSelecionado.ID);
            }

            treino.NomeTreino = txtNomeTreino.Text;
            treino.Descricao = txtDescricao.Text;

            treino.DataInicio = DateTime.TryParse(txtDataInicio.Text, out var dtInicio) ? dtInicio : DateTime.Now;
            treino.DataFim = DateTime.TryParse(txtDataFim.Text, out var dtFim) ? dtFim : DateTime.Now.AddMonths(1);
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var treino = _treinoService.ReadById<Treino>(id);
                    PreencheObjeto(treino);
                    _treinoService.Update<Treino, Treino, TreinoValidator>(treino);
                }
                else
                {
                    var treino = new Treino();
                    PreencheObjeto(treino);
                    _treinoService.Create<Treino, Treino, TreinoValidator>(treino);
                }

                TabControlCadastro.SelectedIndex = 1;
                CarregaGrid();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show(msg, "Erro ao Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _treinoService.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show(msg, "Erro ao Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _treinos = _treinoService.ReadAll<Treino>().ToList();

            var dadosGrid = _treinos.Select(t => new
            {
                t.ID,
                t.NomeTreino,
                Aluno = t.Aluno != null ? t.Aluno.Nome : "Não informado",
                t.Descricao,
                DataInicio = t.DataInicio.ToString("dd/MM/yyyy"),
                DataFim = t.DataFim.ToString("dd/MM/yyyy")
            }).ToList();

            dataGridViewConsulta.DataSource = dadosGrid;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            if (int.TryParse(row.Cells["ID"].Value?.ToString(), out int id))
            {
                var treino = _treinos.FirstOrDefault(t => t.ID == id);
                if (treino != null)
                {
                    txtId.Text = treino.ID.ToString();
                    txtNomeTreino.Text = treino.NomeTreino;
                    txtDescricao.Text = treino.Descricao;
                    txtDataInicio.Text = treino.DataInicio.ToString("dd/MM/yyyy");
                    txtDataFim.Text = treino.DataFim.ToString("dd/MM/yyyy");

                    if (treino.Aluno != null)
                    {
                        cboAluno.SelectedValue = treino.Aluno.ID;
                    }
                }
            }
        }
    }
}
