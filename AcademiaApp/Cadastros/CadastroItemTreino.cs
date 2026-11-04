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
    public partial class CadastroItemTreino : CadastroBase
    {
        private readonly IBaseService<ItemTreino> _itemTreinoService;
        private readonly IBaseService<Treino> _treinoService;
        private readonly IBaseService<Exercicio> _exercicioService;

        private List<ItemTreino> _itensTemporarios = new();
        private List<ItemTreino> _itensTreino = new();

        public CadastroItemTreino(
            IBaseService<ItemTreino> itemTreinoService,
            IBaseService<Treino> treinoService,
            IBaseService<Exercicio> exercicioService)
        {
            _itemTreinoService = itemTreinoService;
            _treinoService = treinoService;
            _exercicioService = exercicioService;

            InitializeComponent();
            CarregaCombos();
            CarregaGrid();
        }

        private void CarregaCombos()
        {
            cboTreino.DataSource = _treinoService.ReadAll<Treino>().ToList();
            cboTreino.DisplayMember = "NomeTreino";
            cboTreino.ValueMember = "ID";

            cboExercicio.DataSource = _exercicioService.ReadAll<Exercicio>().ToList();
            cboExercicio.DisplayMember = "Nome";
            cboExercicio.ValueMember = "ID";
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cboExercicio.SelectedItem is Exercicio exercicioSelecionado &&
                cboTreino.SelectedItem is Treino treinoSelecionado)
            {
                var item = new ItemTreino
                {
                    Treino = _treinoService.ReadById<Treino>(treinoSelecionado.ID),
                    Exercicio = _exercicioService.ReadById<Exercicio>(exercicioSelecionado.ID),
                    Series = int.TryParse(txtSeries.Text, out int s) ? s : 0,
                    Repeticoes = txtRepeticoes.Text,
                    CargaRecomendada = txtCarga.Text
                };

                _itensTemporarios.Add(item);
                AtualizaGridTemporaria();

                txtSeries.Clear();
                txtRepeticoes.Clear();
                txtCarga.Clear();
                cboExercicio.Focus();
            }
        }

        private void AtualizaGridTemporaria()
        {
            dgvItensTemporarios.DataSource = null;
            dgvItensTemporarios.DataSource = _itensTemporarios.Select(i => new
            {
                Exercício = i.Exercicio != null ? i.Exercicio.Nome : "",
                Séries = i.Series,
                Repetições = i.Repeticoes,
                Carga = i.CargaRecomendada
            }).ToList();
        }

        protected override void Salvar()
        {
            try
            {
                if (_itensTemporarios.Count == 0)
                {
                    MessageBox.Show("Adicione pelo menos um exercício na lista clicando no botão Adicionar antes de salvar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                foreach (var item in _itensTemporarios)
                {
                    _itemTreinoService.Create<ItemTreino, ItemTreino, ItemTreinoValidator>(item);
                }

                MessageBox.Show("Exercícios do treino salvos com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                _itensTemporarios.Clear();
                AtualizaGridTemporaria();
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
                _itemTreinoService.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                var msg = ex.InnerException != null ? ex.InnerException.Message : ex.Message;
                MessageBox.Show(msg, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _itensTreino = _itemTreinoService.ReadAll<ItemTreino>().ToList();

            var dadosGrid = _itensTreino.Select(i => new
            {
                i.ID,
                Treino = i.Treino != null ? i.Treino.NomeTreino : "Não informado",
                Aluno = (i.Treino != null && i.Treino.Aluno != null) ? i.Treino.Aluno.Nome : "Não informado",
                Exercício = i.Exercicio != null ? i.Exercicio.Nome : "Não informado",
                Séries = i.Series,
                Repetições = i.Repeticoes,
                Carga = i.CargaRecomendada
            }).ToList();

            dataGridViewConsulta.DataSource = dadosGrid;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            if (int.TryParse(row.Cells["ID"].Value?.ToString(), out int id))
            {
                var itemTreino = _itensTreino.FirstOrDefault(i => i.ID == id);
                if (itemTreino != null)
                {
                    txtId.Text = itemTreino.ID.ToString();
                    txtSeries.Text = itemTreino.Series.ToString();
                    txtRepeticoes.Text = itemTreino.Repeticoes;
                    txtCarga.Text = itemTreino.CargaRecomendada;

                    if (itemTreino.Treino != null)
                    {
                        cboTreino.SelectedValue = itemTreino.Treino.ID;
                    }

                    if (itemTreino.Exercicio != null)
                    {
                        cboExercicio.SelectedValue = itemTreino.Exercicio.ID;
                    }
                }
            }
        }
    }
}
