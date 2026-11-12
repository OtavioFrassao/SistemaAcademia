namespace AcademiaApp
{
    partial class FormPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            cadastrosToolStripMenuItem = new ToolStripMenuItem();
            alunoToolStripMenuItem = new ToolStripMenuItem();
            exercicioToolStripMenuItem = new ToolStripMenuItem();
            avaliaçãoFisicaToolStripMenuItem = new ToolStripMenuItem();
            treinoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.FromArgb(253, 242, 248);
            menuStrip1.Items.AddRange(new ToolStripItem[] { cadastrosToolStripMenuItem });
            menuStrip1.Location = new Point(3, 64);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(873, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // cadastrosToolStripMenuItem
            // 
            cadastrosToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alunoToolStripMenuItem, exercicioToolStripMenuItem, avaliaçãoFisicaToolStripMenuItem, treinoToolStripMenuItem });
            cadastrosToolStripMenuItem.Name = "cadastrosToolStripMenuItem";
            cadastrosToolStripMenuItem.Size = new Size(71, 20);
            cadastrosToolStripMenuItem.Text = "Cadastros";
            // 
            // alunoToolStripMenuItem
            // 
            alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            alunoToolStripMenuItem.Size = new Size(157, 22);
            alunoToolStripMenuItem.Text = "Aluno";
            alunoToolStripMenuItem.Click += alunoToolStripMenuItem_Click;
            // 
            // exercicioToolStripMenuItem
            // 
            exercicioToolStripMenuItem.Name = "exercicioToolStripMenuItem";
            exercicioToolStripMenuItem.Size = new Size(157, 22);
            exercicioToolStripMenuItem.Text = "Exercicio";
            exercicioToolStripMenuItem.Click += exercicioToolStripMenuItem_Click;
            // 
            // avaliaçãoFisicaToolStripMenuItem
            // 
            avaliaçãoFisicaToolStripMenuItem.Name = "avaliaçãoFisicaToolStripMenuItem";
            avaliaçãoFisicaToolStripMenuItem.Size = new Size(157, 22);
            avaliaçãoFisicaToolStripMenuItem.Text = "Avaliação Fisica";
            avaliaçãoFisicaToolStripMenuItem.Click += avaliaçãoFisicaToolStripMenuItem_Click;
            // 
            // treinoToolStripMenuItem
            // 
            treinoToolStripMenuItem.Name = "treinoToolStripMenuItem";
            treinoToolStripMenuItem.Size = new Size(157, 22);
            treinoToolStripMenuItem.Text = "Treino";
            treinoToolStripMenuItem.Click += treinoToolStripMenuItem_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(879, 523);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FormPrincipal";
            Text = "Sistema Academia";
            WindowState = FormWindowState.Maximized;
            FormClosing += FormPrincipal_FormClosing;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStripMenuItem cadastrosToolStripMenuItem;
        private ToolStripMenuItem alunoToolStripMenuItem;
        private ToolStripMenuItem exercicioToolStripMenuItem;
        private ToolStripMenuItem avaliaçãoFisicaToolStripMenuItem;
        private ToolStripMenuItem treinoToolStripMenuItem;
        protected MenuStrip menuStrip1;
    }
}
