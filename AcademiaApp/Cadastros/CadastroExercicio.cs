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

            dataGridViewConsulta.Location = new Point(6, 6);

            dataGridViewConsulta.Size = new Size(
                tabPageConsulta.ClientSize.Width - 12,
                tabPageConsulta.ClientSize.Height - 65
            );
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
            dataGridViewConsulta.DataSource = _exercicios;
            if (dataGridViewConsulta.Columns["Nome"] != null)
                dataGridViewConsulta.Columns["Nome"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            txtId.Text = row.Cells["Id"].Value?.ToString() ?? row.Cells["ID"].Value?.ToString();
            txtNome.Text = row.Cells["Nome"].Value?.ToString();
            txtGrupoMuscular.Text = row.Cells["GrupoMuscular"].Value?.ToString();
        }


    }
}