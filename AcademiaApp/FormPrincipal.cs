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
    }
}