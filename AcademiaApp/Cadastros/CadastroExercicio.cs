using AcademiaApp.Base;
using AcademiaDomain;
using AcademiaService.Base;
using AcademiaService.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AcademiaApp.Cadastros
{
    public partial class CadastroExercicio : CadastroBase
    {
        private readonly IBaseService<Exercicio> _exercicioService;
        private List<Exercicio> _exercicios = new();

        public CadastroExercicio(IBaseService<Exercicio> exercicioService)
        {
            _exercicioService = exercicioService;
            InitializeComponent();

            dataGridViewConsulta.Dock = DockStyle.None;

            dataGridViewConsulta.Anchor =
                AnchorStyles.Top |
                AnchorStyles.Bottom |
                AnchorStyles.Left |
                AnchorStyles.Right;

            // Deixa espaço para a barra de pesquisa
            dataGridViewConsulta.Location = new Point(6, 65);

            dataGridViewConsulta.Size = new Size(
                tabPageConsulta.ClientSize.Width - 12,
                tabPageConsulta.ClientSize.Height - 130
            );

            // Garante que o cabeçalho fique visível
            dataGridViewConsulta.ColumnHeadersVisible = true;
            dataGridViewConsulta.ColumnHeadersHeightSizeMode =
                DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewConsulta.ColumnHeadersHeight = 32;

            dataGridViewConsulta.RowHeadersVisible = false;

            CarregaGrid();
        }

        private void PreencheObjeto(Exercicio exercicio)
        {
            exercicio.Nome = txtNome.Text;
            exercicio.GrupoMuscular = txtGrupoMuscular.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var exercicio = _exercicioService.ReadById<Exercicio>(id);
                    PreencheObjeto(exercicio);
                    _exercicioService.Update<Exercicio, Exercicio, ExercicioValidator>(exercicio);
                }
                else
                {
                    var exercicio = new Exercicio();
                    PreencheObjeto(exercicio);
                    _exercicioService.Create<Exercicio, Exercicio, ExercicioValidator>(exercicio);
                }

                TabControlCadastro.SelectedIndex = 1;
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Deletar(int id)
        {
            try
            {
                _exercicioService.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void CarregaGrid()
        {
            _exercicios = _exercicioService.ReadAll<Exercicio>().ToList();
            FiltrarExercicios();
        }

        private void txtPesquisaExercicio_TextChanged(object sender, EventArgs e)
        {
            FiltrarExercicios();
        }

        private void FiltrarExercicios()
        {
            string pesquisa = txtPesquisaExercicio.Text.Trim();

            var dados = _exercicios
                .Where(e =>
                    string.IsNullOrWhiteSpace(pesquisa) ||
                    e.ID.ToString().Contains(pesquisa) ||
                    (e.Nome?.Contains(pesquisa,
                        StringComparison.OrdinalIgnoreCase) ?? false) ||
                    (e.GrupoMuscular?.Contains(pesquisa,
                        StringComparison.OrdinalIgnoreCase) ?? false))
                .Select(e => new
                {
                    e.ID,
                    e.Nome,
                    e.GrupoMuscular
                })
                .ToList();

            dataGridViewConsulta.DataSource = null;
            dataGridViewConsulta.Columns.Clear();
            dataGridViewConsulta.AutoGenerateColumns = true;
            dataGridViewConsulta.DataSource = dados;


            dataGridViewConsulta.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.Fill;

            dataGridViewConsulta.Columns["ID"].FillWeight = 12;
            dataGridViewConsulta.Columns["Nome"].FillWeight = 48;
            dataGridViewConsulta.Columns["GrupoMuscular"].FillWeight = 40;

            dataGridViewConsulta.Columns["GrupoMuscular"].HeaderText =
                "Grupo Muscular";

        }


        protected override void CarregarRegistro(DataGridViewRow row)
        {
            txtId.Text = row.Cells["Id"].Value?.ToString() ?? row.Cells["ID"].Value?.ToString();
            txtNome.Text = row.Cells["Nome"].Value?.ToString();
            txtGrupoMuscular.Text = row.Cells["GrupoMuscular"].Value?.ToString();
        }


    }
}