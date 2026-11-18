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
    public partial class CadastroAluno : CadastroBase
    {
        private readonly IBaseService<Aluno> _alunoService;
        private List<Aluno> _alunos = new();
        public CadastroAluno(IBaseService<Aluno> alunoService)
        {
            _alunoService = alunoService;
            InitializeComponent();
            CarregaGrid();
        }

        private void PreencheObjeto(Aluno aluno)
        {
            aluno.Nome = txtNome.Text;
            aluno.CPF = txtCpf.Text;
            aluno.DataNascimento = DateTime.TryParse(txtDataNascimento.Text, out var data) ? data : DateTime.MinValue;
            aluno.Telefone = txtTelefone.Text;
            aluno.Email = txtEmail.Text;
        }

        protected override void Salvar()
        {
            try
            {
                if (IsEditMode)
                {
                    var id = Convert.ToInt32(txtId.Text);
                    var aluno = _alunoService.ReadById<Aluno>(id);
                    PreencheObjeto(aluno);
                    _alunoService.Update<Aluno, Aluno, AlunoValidator>(aluno);
                }
                else
                {
                    var aluno = new Aluno();
                    PreencheObjeto(aluno);
                    _alunoService.Create<Aluno, Aluno, AlunoValidator>(aluno);
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
                _alunoService.Delete(id);
                CarregaGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            _alunos = _alunoService.ReadAll<Aluno>().ToList();
            FiltrarAlunos();
        }

        protected override void CarregarRegistro(DataGridViewRow row)
        {
            txtId.Text = row.Cells["Id"].Value?.ToString() ?? row.Cells["ID"].Value?.ToString();
            txtNome.Text = row.Cells["Nome"].Value?.ToString();
            txtCpf.Text = row.Cells["Cpf"].Value?.ToString();
            txtDataNascimento.Text = Convert.ToDateTime(row.Cells["DataNascimento"].Value).ToString("dd/MM/yyyy");
            txtTelefone.Text = row.Cells["Telefone"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
        }


        private void txtPesquisaAluno_TextChanged(object sender, EventArgs e)
        {
            FiltrarAlunos();
        }


        private void FiltrarAlunos()
        {
            string pesquisa = txtPesquisaAluno.Text.Trim();

            var alunosFiltrados = _alunos
                .Where(aluno =>
                    string.IsNullOrWhiteSpace(pesquisa) ||
                    (aluno.Nome?.Contains(
                        pesquisa,
                        StringComparison.OrdinalIgnoreCase
                    ) ?? false) ||
                    aluno.ID.ToString().Contains(pesquisa)
                )
                .Select(aluno => new
                {
                    ID = aluno.ID,
                    Nome = aluno.Nome,
                    Telefone = aluno.Telefone,
                    Email = aluno.Email,
                    CPF = aluno.CPF,
                    DataNascimento = aluno.DataNascimento
                })
                .ToList();

            dataGridViewConsulta.DataSource = null;
            dataGridViewConsulta.AutoGenerateColumns = true;
            dataGridViewConsulta.DataSource = alunosFiltrados;

            dataGridViewConsulta.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.None;

            dataGridViewConsulta.RowHeadersVisible = false;

            dataGridViewConsulta.Columns["ID"].Width = 45;
            dataGridViewConsulta.Columns["Telefone"].Width = 125;
            dataGridViewConsulta.Columns["Email"].Width = 180;
            dataGridViewConsulta.Columns["CPF"].Width = 125;

            dataGridViewConsulta.Columns["DataNascimento"].Width = 115;
            dataGridViewConsulta.Columns["DataNascimento"].HeaderText =
                "Nascimento";

            dataGridViewConsulta.Columns["DataNascimento"]
                .DefaultCellStyle.Format = "dd/MM/yyyy";

            dataGridViewConsulta.Columns["Nome"].MinimumWidth = 140;
            dataGridViewConsulta.Columns["Nome"].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.Fill;
        }


    }
}
