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
        private readonly IBaseService<Exercicio> _exercicioService;
        private readonly IBaseService<ItemTreino> _itemTreinoService;
        private List<Treino> _treinos = new();
        private List<ItemTreino> _itensTemporarios = new();
        private int _indiceItemEmEdicao = -1;
        private int _idTreinoEmEdicao = 0;
        private List<int> _idsItensOriginais = new();

        public CadastroTreino(
            IBaseService<Treino> treinoService,
            IBaseService<Aluno> alunoService,
            IBaseService<Exercicio> exercicioService,
            IBaseService<ItemTreino> itemTreinoService)
        {
            _treinoService = treinoService;
            _alunoService = alunoService;
            _exercicioService = exercicioService;
            _itemTreinoService = itemTreinoService;
            InitializeComponent();
            dataGridViewConsulta.SelectionChanged += dataGridViewConsulta_SelectionChanged;

            dataGridViewConsulta.Dock = DockStyle.None;
            dgvExerciciosConsulta.Dock = DockStyle.None;

            dataGridViewConsulta.Anchor =
                AnchorStyles.Top | AnchorStyles.Left;

            dgvExerciciosConsulta.Anchor =
                AnchorStyles.Top | AnchorStyles.Left;

            int margem = 6;

            int largura = tabPageConsulta.ClientSize.Width - 12;

            dataGridViewConsulta.Location = new Point(6, 6);
            dataGridViewConsulta.Size = new Size(largura, 320);

            dgvExerciciosConsulta.Location = new Point(6, 335);
            dgvExerciciosConsulta.Size = new Size(largura, 315);

            txtDataInicio.Mask = "00/00/0000";
            txtDataFim.Mask = "00/00/0000";

            tabPageConsulta.Resize += (sender, e) => AjustarLarguraTabelas();

            this.Shown += (sender, e) => AjustarLarguraTabelas();

            CarregaCombo();
            CarregaExercicios();
            CarregaGrid();
        }

        private void AjustarLarguraTabelas()
        {
            int margem = 6;

            int largura = tabPageConsulta.ClientSize.Width - (margem * 2);

            if (largura > 0)
            {
                dataGridViewConsulta.Left = margem;
                dgvExerciciosConsulta.Left = margem;

                dataGridViewConsulta.Width = largura;
                dgvExerciciosConsulta.Width = largura;
            }
        }
        private void dataGridViewConsulta_SelectionChanged( object sender, EventArgs e)
        {
            CarregarItensDoTreino();
        }

        private void CarregaCombo()
        {
            cboAluno.DataSource = _alunoService.ReadAll<Aluno>().ToList();
            cboAluno.DisplayMember = "Nome";
            cboAluno.ValueMember = "ID";
        }

        private void CarregaExercicios()
        {
            cboExercicio.DataSource = _exercicioService.ReadAll<Exercicio>().ToList();
            cboExercicio.DisplayMember = "Nome";
            cboExercicio.ValueMember = "ID";
        }

        private void AtualizaGridTemporaria()
        {
            dgvItensTreino.DataSource = null;

            dgvItensTreino.DataSource = _itensTemporarios
                .Select((i, indice) => new
                {
                    Indice = indice,
                    Exercicio = i.Exercicio?.Nome ?? "",
                    Series = i.Series,
                    Repeticoes = i.Repeticoes,
                    Carga = i.CargaRecomendada
                }).ToList();

            dgvItensTreino.Columns["Indice"].Visible = false;

            dgvItensTreino.ClearSelection();
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


        private void VincularItensAoTreino(Treino treino)
        {
            foreach (var item in _itensTemporarios)
            {
                var novoItem = new ItemTreino
                {
                    Treino = treino,
                    Exercicio = item.Exercicio,
                    Series = item.Series,
                    Repeticoes = item.Repeticoes,
                    CargaRecomendada = item.CargaRecomendada
                };

                treino.ItensTreino.Add(novoItem);
            }
        }
        protected override void Salvar()
        {
            try
            {
                if (_itensTemporarios.Count == 0)
                {
                    MessageBox.Show(
                        "Adicione pelo menos um exercício antes de salvar o treino!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }

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

                    VincularItensAoTreino(treino);

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

            dataGridViewConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
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
                    CarregarItensParaEdicao(treino.ID);
                }
            }
        }


        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (cboExercicio.SelectedItem is not Exercicio exercicio)
            {
                MessageBox.Show("Selecione um exercício!");
                return;
            }

            if (!int.TryParse(txtSeries.Text, out int series) || series <= 0)
            {
                MessageBox.Show("Informe uma quantidade válida de séries!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtRepeticoes.Text))
            {
                MessageBox.Show("Informe as repetições!");
                return;
            }

            var item = new ItemTreino
            {
                Exercicio = exercicio,
                Series = series,
                Repeticoes = txtRepeticoes.Text.Trim(),
                CargaRecomendada = txtCarga.Text.Trim()
            };

            if (_indiceItemEmEdicao >= 0)
            {
                if (_indiceItemEmEdicao >= _itensTemporarios.Count)
                {
                    MessageBox.Show("O exercício em edição não foi encontrado!");
                    _indiceItemEmEdicao = -1;
                    return;
                }

                var itemOriginal = _itensTemporarios[_indiceItemEmEdicao];

                item.ID = itemOriginal.ID;

                item.Treino = itemOriginal.Treino;

                _itensTemporarios[_indiceItemEmEdicao] = item;

                _indiceItemEmEdicao = -1;

                MessageBox.Show("Exercício atualizado com sucesso!");
            }
            else
            {
                _itensTemporarios.Add(item);
            }

            AtualizaGridTemporaria();

            txtSeries.Clear();
            txtRepeticoes.Clear();
            txtCarga.Clear();

            cboExercicio.Focus();
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (dgvItensTreino.SelectedRows.Count == 0)
            {
                MessageBox.Show(
                    "Selecione um exercício para remover!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            var linha = dgvItensTreino.SelectedRows[0];

            if (!int.TryParse(
                    linha.Cells["Indice"].Value?.ToString(),
                    out int indice) ||
                indice < 0 ||
                indice >= _itensTemporarios.Count)
            {
                MessageBox.Show("Não foi possível localizar o exercício.");
                return;
            }

            var resposta = MessageBox.Show(
                "Deseja remover o exercício selecionado?",
                "Confirmar Remoção",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                _itensTemporarios.RemoveAt(indice);

                _indiceItemEmEdicao = -1;

                cboExercicio.SelectedIndex = -1;
                txtSeries.Clear();
                txtRepeticoes.Clear();
                txtCarga.Clear();

                AtualizaGridTemporaria();

                MessageBox.Show(
                    "Exercício removido da lista!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }


        private void btnEditarItem_Click(object sender, EventArgs e)
        {
            if (dgvItensTreino.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um exercício para editar!");
                return;
            }

            var linha = dgvItensTreino.SelectedRows[0];

            if (!int.TryParse(
                linha.Cells["Indice"].Value?.ToString(),
                out int indice) ||
                indice < 0 ||
                indice >= _itensTemporarios.Count)
            {
                MessageBox.Show("Não foi possível localizar o exercício.");
                return;
            }

            _indiceItemEmEdicao = indice;

            var item = _itensTemporarios[indice];

            cboExercicio.SelectedValue = item.Exercicio.ID;
            txtSeries.Text = item.Series.ToString();
            txtRepeticoes.Text = item.Repeticoes;
            txtCarga.Text = item.CargaRecomendada;

            txtSeries.Focus();
        }


        private void CarregarItensDoTreino()
        {
            dgvExerciciosConsulta.DataSource = null;

            if (dataGridViewConsulta.SelectedRows.Count == 0)
                return;

            var linha = dataGridViewConsulta.SelectedRows[0];

            if (!int.TryParse(
                linha.Cells["Id"].Value?.ToString(),
                out int idTreino))
                return;

            var itens = _itemTreinoService
                .ReadAll<ItemTreino>()
                .Where(i => i.Treino != null && i.Treino.ID == idTreino)
                .Select(i => new
                {
                    Exercicio = i.Exercicio?.Nome ?? "Não informado",
                    Series = i.Series,
                    Repeticoes = i.Repeticoes,
                    Carga = i.CargaRecomendada
                })
                .ToList();

            dgvExerciciosConsulta.DataSource = itens;
            dgvExerciciosConsulta.ClearSelection();
        }


        private void CarregarItensParaEdicao(int idTreino)
        {
            _idTreinoEmEdicao = idTreino;

            _indiceItemEmEdicao = -1;

            _itensTemporarios.Clear();

            var itens = _itemTreinoService
                .ReadAll<ItemTreino>()
                .Where(i => i.Treino != null &&
                            i.Treino.ID == idTreino)
                .ToList();

            _itensTemporarios.AddRange(itens);

            _idsItensOriginais = itens.Select(i => i.ID).ToList();

            AtualizaGridTemporaria();
        }


    }
}
