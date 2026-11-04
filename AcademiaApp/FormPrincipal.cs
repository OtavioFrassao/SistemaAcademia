using AcademiaApp.Cadastros;
using AcademiaApp.Infra;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using System;

namespace AcademiaApp
{
    public partial class FormPrincipal : MaterialForm
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            foreach (Control control in this.Controls)
            {
                if (control is MdiClient mdiClient)
                {
                    mdiClient.BackgroundImage = Properties.Resources.imagem_fundo;

                    // Define como a imagem se comporta (Stretch estica, Center centraliza, Zoom redimensiona proporcionalmente)
                    mdiClient.BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                }
            }
        }

        private void exercicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroExercicio = ConfigureDI.ServiceProvider.GetService<CadastroExercicio>();
            if (cadastroExercicio != null)
            {
                cadastroExercicio.MdiParent = this;
                cadastroExercicio.Show();
            }
            else
            {
                MessageBox.Show("Não foi possível carregar a tela de Exercício. Verifique se ela foi registrada na classe ConfigureDI.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroAluno = ConfigureDI.ServiceProvider.GetService<CadastroAluno>();
            if (cadastroAluno != null)
            {
                cadastroAluno.MdiParent = this;
                cadastroAluno.Show();
            }
            else
            {
                MessageBox.Show("Não foi possível carregar a tela de Aluno. Verifique a classe ConfigureDI.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void avaliaçãoFisicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroAvaliacao = ConfigureDI.ServiceProvider.GetService<CadastroAvaliacaoFisica>();
            if (cadastroAvaliacao != null)
            {
                cadastroAvaliacao.MdiParent = this;
                cadastroAvaliacao.Show();
            }
        }

        private void treinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroTreino = ConfigureDI.ServiceProvider.GetService<CadastroTreino>();
            if (cadastroTreino != null)
            {
                cadastroTreino.MdiParent = this;
                cadastroTreino.Show();
            }
        }

        private void itemTreinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cadastroItemTreino = ConfigureDI.ServiceProvider.GetService<CadastroItemTreino>();
            if (cadastroItemTreino != null)
            {
                cadastroItemTreino.MdiParent = this;
                cadastroItemTreino.Show();
            }
        }
    }
}