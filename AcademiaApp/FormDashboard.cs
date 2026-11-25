using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using AcademiaApp.Infra;
using AcademiaApp.Base;
using AcademiaDomain;
using AcademiaService.Base;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace AcademiaApp
{
    public partial class FormDashboard : Form
    {

        public FormDashboard()
        {
            InitializeComponent();

            this.Shown += (sender, e) =>
            {
                CadastroBase.DadosAlterados += AtualizarIndicadores;
                AtualizarIndicadores();
            };

            this.FormClosed += (sender, e) =>
            {
                CadastroBase.DadosAlterados -= AtualizarIndicadores;
            };
        }

        private void AtualizarIndicadores()
        {
            try
            {
                using var scope =
                    ConfigureDI.ServiceProvider.CreateScope();

                var alunos = scope.ServiceProvider
                    .GetRequiredService<IBaseService<Aluno>>();

                var exercicios = scope.ServiceProvider
                    .GetRequiredService<IBaseService<Exercicio>>();

                var treinos = scope.ServiceProvider
                    .GetRequiredService<IBaseService<Treino>>();

                var avaliacoes = scope.ServiceProvider
                    .GetRequiredService<IBaseService<AvaliacaoFisica>>();

                lblTotalAlunos.Text =
                    alunos.ReadAll<Aluno>().Count().ToString();

                lblTotalExercicios.Text =
                    exercicios.ReadAll<Exercicio>().Count().ToString();

                lblTotalTreinos.Text =
                    treinos.ReadAll<Treino>().Count().ToString();

                lblTotalAvaliacoes.Text =
                    avaliacoes.ReadAll<AvaliacaoFisica>().Count().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Erro ao carregar Dashboard",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


    }
}
