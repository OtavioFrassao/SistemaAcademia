namespace AcademiaApp
{
    partial class FormDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panelAvaliacoes = new Panel();
            lblTotalAvaliacoes = new Label();
            lblTituloAvaliacoes = new Label();
            panelTreinos = new Panel();
            lblTotalTreinos = new Label();
            lblTituloTreinos = new Label();
            panelExercicios = new Panel();
            lblTotalExercicios = new Label();
            lblTituloExercicios = new Label();
            panelAlunos = new Panel();
            lblTotalAlunos = new Label();
            lblTituloAlunos = new Label();
            lblTitulo = new ReaLTaiizor.Controls.CrownLabel();
            pictureBoxKitty = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panelAvaliacoes.SuspendLayout();
            panelTreinos.SuspendLayout();
            panelExercicios.SuspendLayout();
            panelAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKitty).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(panelAvaliacoes, 3, 0);
            tableLayoutPanel1.Controls.Add(panelTreinos, 2, 0);
            tableLayoutPanel1.Controls.Add(panelExercicios, 1, 0);
            tableLayoutPanel1.Controls.Add(panelAlunos, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 65);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(800, 229);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelAvaliacoes
            // 
            panelAvaliacoes.BackColor = Color.White;
            panelAvaliacoes.BorderStyle = BorderStyle.FixedSingle;
            panelAvaliacoes.Controls.Add(lblTotalAvaliacoes);
            panelAvaliacoes.Controls.Add(lblTituloAvaliacoes);
            panelAvaliacoes.Dock = DockStyle.Fill;
            panelAvaliacoes.Location = new Point(608, 8);
            panelAvaliacoes.Margin = new Padding(8);
            panelAvaliacoes.Name = "panelAvaliacoes";
            panelAvaliacoes.Size = new Size(184, 213);
            panelAvaliacoes.TabIndex = 6;
            // 
            // lblTotalAvaliacoes
            // 
            lblTotalAvaliacoes.AutoSize = true;
            lblTotalAvaliacoes.Font = new Font("Segoe UI", 15F);
            lblTotalAvaliacoes.ForeColor = Color.FromArgb(219, 39, 119);
            lblTotalAvaliacoes.Location = new Point(3, 35);
            lblTotalAvaliacoes.Name = "lblTotalAvaliacoes";
            lblTotalAvaliacoes.Size = new Size(23, 28);
            lblTotalAvaliacoes.TabIndex = 2;
            lblTotalAvaliacoes.Text = "0";
            // 
            // lblTituloAvaliacoes
            // 
            lblTituloAvaliacoes.AutoSize = true;
            lblTituloAvaliacoes.Font = new Font("Segoe UI", 11F);
            lblTituloAvaliacoes.ForeColor = Color.MediumVioletRed;
            lblTituloAvaliacoes.Location = new Point(3, 15);
            lblTituloAvaliacoes.Name = "lblTituloAvaliacoes";
            lblTituloAvaliacoes.Size = new Size(93, 20);
            lblTituloAvaliacoes.TabIndex = 0;
            lblTituloAvaliacoes.Text = "AVALIAÇÕES";
            // 
            // panelTreinos
            // 
            panelTreinos.BackColor = Color.White;
            panelTreinos.BorderStyle = BorderStyle.FixedSingle;
            panelTreinos.Controls.Add(lblTotalTreinos);
            panelTreinos.Controls.Add(lblTituloTreinos);
            panelTreinos.Dock = DockStyle.Fill;
            panelTreinos.Location = new Point(408, 8);
            panelTreinos.Margin = new Padding(8);
            panelTreinos.Name = "panelTreinos";
            panelTreinos.Size = new Size(184, 213);
            panelTreinos.TabIndex = 5;
            // 
            // lblTotalTreinos
            // 
            lblTotalTreinos.AutoSize = true;
            lblTotalTreinos.Font = new Font("Segoe UI", 15F);
            lblTotalTreinos.ForeColor = Color.FromArgb(219, 39, 119);
            lblTotalTreinos.Location = new Point(3, 35);
            lblTotalTreinos.Name = "lblTotalTreinos";
            lblTotalTreinos.Size = new Size(23, 28);
            lblTotalTreinos.TabIndex = 2;
            lblTotalTreinos.Text = "0";
            // 
            // lblTituloTreinos
            // 
            lblTituloTreinos.AutoSize = true;
            lblTituloTreinos.Font = new Font("Segoe UI", 11F);
            lblTituloTreinos.ForeColor = Color.MediumVioletRed;
            lblTituloTreinos.Location = new Point(3, 15);
            lblTituloTreinos.Name = "lblTituloTreinos";
            lblTituloTreinos.Size = new Size(68, 20);
            lblTituloTreinos.TabIndex = 0;
            lblTituloTreinos.Text = "TREINOS";
            // 
            // panelExercicios
            // 
            panelExercicios.BackColor = Color.White;
            panelExercicios.BorderStyle = BorderStyle.FixedSingle;
            panelExercicios.Controls.Add(lblTotalExercicios);
            panelExercicios.Controls.Add(lblTituloExercicios);
            panelExercicios.Dock = DockStyle.Fill;
            panelExercicios.Location = new Point(208, 8);
            panelExercicios.Margin = new Padding(8);
            panelExercicios.Name = "panelExercicios";
            panelExercicios.Size = new Size(184, 213);
            panelExercicios.TabIndex = 4;
            // 
            // lblTotalExercicios
            // 
            lblTotalExercicios.AutoSize = true;
            lblTotalExercicios.Font = new Font("Segoe UI", 15F);
            lblTotalExercicios.ForeColor = Color.FromArgb(219, 39, 119);
            lblTotalExercicios.Location = new Point(3, 35);
            lblTotalExercicios.Name = "lblTotalExercicios";
            lblTotalExercicios.Size = new Size(23, 28);
            lblTotalExercicios.TabIndex = 2;
            lblTotalExercicios.Text = "0";
            // 
            // lblTituloExercicios
            // 
            lblTituloExercicios.AutoSize = true;
            lblTituloExercicios.Font = new Font("Segoe UI", 11F);
            lblTituloExercicios.ForeColor = Color.MediumVioletRed;
            lblTituloExercicios.Location = new Point(3, 15);
            lblTituloExercicios.Name = "lblTituloExercicios";
            lblTituloExercicios.Size = new Size(88, 20);
            lblTituloExercicios.TabIndex = 0;
            lblTituloExercicios.Text = "EXERCÍCIOS";
            // 
            // panelAlunos
            // 
            panelAlunos.BackColor = Color.White;
            panelAlunos.BorderStyle = BorderStyle.FixedSingle;
            panelAlunos.Controls.Add(lblTotalAlunos);
            panelAlunos.Controls.Add(lblTituloAlunos);
            panelAlunos.Dock = DockStyle.Fill;
            panelAlunos.Location = new Point(8, 8);
            panelAlunos.Margin = new Padding(8);
            panelAlunos.Name = "panelAlunos";
            panelAlunos.Size = new Size(184, 213);
            panelAlunos.TabIndex = 3;
            // 
            // lblTotalAlunos
            // 
            lblTotalAlunos.AutoSize = true;
            lblTotalAlunos.Font = new Font("Segoe UI", 15F);
            lblTotalAlunos.ForeColor = Color.FromArgb(219, 39, 119);
            lblTotalAlunos.Location = new Point(3, 35);
            lblTotalAlunos.Name = "lblTotalAlunos";
            lblTotalAlunos.Size = new Size(23, 28);
            lblTotalAlunos.TabIndex = 1;
            lblTotalAlunos.Text = "0";
            // 
            // lblTituloAlunos
            // 
            lblTituloAlunos.AutoSize = true;
            lblTituloAlunos.Font = new Font("Segoe UI", 11F);
            lblTituloAlunos.ForeColor = Color.MediumVioletRed;
            lblTituloAlunos.Location = new Point(3, 15);
            lblTituloAlunos.Name = "lblTituloAlunos";
            lblTituloAlunos.Size = new Size(66, 20);
            lblTituloAlunos.TabIndex = 0;
            lblTituloAlunos.Text = "ALUNOS";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 20F);
            lblTitulo.ForeColor = Color.FromArgb(190, 24, 93);
            lblTitulo.Location = new Point(-1, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(417, 37);
            lblTitulo.TabIndex = 2;
            lblTitulo.Text = "🎀 Dashboard — Hello Kitty Gym";
            // 
            // pictureBoxKitty
            // 
            pictureBoxKitty.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBoxKitty.BackColor = Color.Transparent;
            pictureBoxKitty.Image = Properties.Resources.imagem_fundo;
            pictureBoxKitty.Location = new Point(12, 300);
            pictureBoxKitty.Name = "pictureBoxKitty";
            pictureBoxKitty.Size = new Size(800, 138);
            pictureBoxKitty.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxKitty.TabIndex = 3;
            pictureBoxKitty.TabStop = false;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 242, 248);
            ClientSize = new Size(827, 450);
            Controls.Add(pictureBoxKitty);
            Controls.Add(lblTitulo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            Text = "Dashboard";
            WindowState = FormWindowState.Maximized;
            tableLayoutPanel1.ResumeLayout(false);
            panelAvaliacoes.ResumeLayout(false);
            panelAvaliacoes.PerformLayout();
            panelTreinos.ResumeLayout(false);
            panelTreinos.PerformLayout();
            panelExercicios.ResumeLayout(false);
            panelExercicios.PerformLayout();
            panelAlunos.ResumeLayout(false);
            panelAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKitty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private ReaLTaiizor.Controls.CrownLabel lblTitulo;
        private Panel panelAlunos;
        private Label lblTituloAlunos;
        private Panel panelTreinos;
        private Label lblTituloTreinos;
        private Panel panelExercicios;
        private Label lblTituloExercicios;
        private Label lblTotalAlunos;
        private Panel panelAvaliacoes;
        private Label lblTituloAvaliacoes;
        private Label lblTotalAvaliacoes;
        private Label lblTotalTreinos;
        private Label lblTotalExercicios;
        private PictureBox pictureBoxKitty;
    }
}