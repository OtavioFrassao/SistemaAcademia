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
            picAvaliacoes = new PictureBox();
            label3 = new Label();
            lblTotalAvaliacoes = new Label();
            lblTituloAvaliacoes = new Label();
            panelTreinos = new Panel();
            label2 = new Label();
            picTreinos = new PictureBox();
            lblTotalTreinos = new Label();
            lblTituloTreinos = new Label();
            panelExercicios = new Panel();
            picExercicios = new PictureBox();
            label1 = new Label();
            lblTotalExercicios = new Label();
            lblTituloExercicios = new Label();
            panelAlunos = new Panel();
            picAlunos = new PictureBox();
            lblPainel = new Label();
            lblTotalAlunos = new Label();
            lblTituloAlunos = new Label();
            lblTitulo = new ReaLTaiizor.Controls.CrownLabel();
            pictureBoxKitty = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            panelAvaliacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAvaliacoes).BeginInit();
            panelTreinos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picTreinos).BeginInit();
            panelExercicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picExercicios).BeginInit();
            panelAlunos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picAlunos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxKitty).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top;
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
            tableLayoutPanel1.Size = new Size(1120, 230);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // panelAvaliacoes
            // 
            panelAvaliacoes.BackColor = Color.White;
            panelAvaliacoes.Controls.Add(picAvaliacoes);
            panelAvaliacoes.Controls.Add(label3);
            panelAvaliacoes.Controls.Add(lblTotalAvaliacoes);
            panelAvaliacoes.Controls.Add(lblTituloAvaliacoes);
            panelAvaliacoes.ForeColor = Color.FromArgb(219, 39, 119);
            panelAvaliacoes.Location = new Point(848, 8);
            panelAvaliacoes.Margin = new Padding(8);
            panelAvaliacoes.Name = "panelAvaliacoes";
            panelAvaliacoes.Size = new Size(264, 213);
            panelAvaliacoes.TabIndex = 6;
            // 
            // picAvaliacoes
            // 
            picAvaliacoes.Image = Properties.Resources.Ícone_de_ECG_em_Rosa_Vibrante;
            picAvaliacoes.Location = new Point(92, 26);
            picAvaliacoes.Name = "picAvaliacoes";
            picAvaliacoes.Size = new Size(72, 64);
            picAvaliacoes.SizeMode = PictureBoxSizeMode.Zoom;
            picAvaliacoes.TabIndex = 6;
            picAvaliacoes.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(74, 177);
            label3.Name = "label3";
            label3.Size = new Size(109, 19);
            label3.TabIndex = 5;
            label3.Text = "Total cadastrado";
            // 
            // lblTotalAvaliacoes
            // 
            lblTotalAvaliacoes.BackColor = Color.Transparent;
            lblTotalAvaliacoes.Font = new Font("Segoe UI", 20F);
            lblTotalAvaliacoes.ForeColor = Color.FromArgb(219, 39, 119);
            lblTotalAvaliacoes.Location = new Point(114, 82);
            lblTotalAvaliacoes.Name = "lblTotalAvaliacoes";
            lblTotalAvaliacoes.Size = new Size(27, 50);
            lblTotalAvaliacoes.TabIndex = 2;
            lblTotalAvaliacoes.Text = "0";
            lblTotalAvaliacoes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloAvaliacoes
            // 
            lblTituloAvaliacoes.AutoSize = true;
            lblTituloAvaliacoes.Font = new Font("Segoe UI", 14F);
            lblTituloAvaliacoes.ForeColor = Color.MediumVioletRed;
            lblTituloAvaliacoes.Location = new Point(74, 132);
            lblTituloAvaliacoes.Name = "lblTituloAvaliacoes";
            lblTituloAvaliacoes.Size = new Size(117, 25);
            lblTituloAvaliacoes.TabIndex = 0;
            lblTituloAvaliacoes.Text = "AVALIAÇÕES";
            lblTituloAvaliacoes.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelTreinos
            // 
            panelTreinos.BackColor = Color.White;
            panelTreinos.Controls.Add(label2);
            panelTreinos.Controls.Add(picTreinos);
            panelTreinos.Controls.Add(lblTotalTreinos);
            panelTreinos.Controls.Add(lblTituloTreinos);
            panelTreinos.ForeColor = Color.FromArgb(219, 39, 119);
            panelTreinos.Location = new Point(568, 8);
            panelTreinos.Margin = new Padding(8);
            panelTreinos.Name = "panelTreinos";
            panelTreinos.Size = new Size(264, 213);
            panelTreinos.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(71, 177);
            label2.Name = "label2";
            label2.Size = new Size(109, 19);
            label2.TabIndex = 10;
            label2.Text = "Total cadastrado";
            // 
            // picTreinos
            // 
            picTreinos.Image = Properties.Resources.Ícone_de_Checklist_em_Magenta;
            picTreinos.Location = new Point(85, 26);
            picTreinos.Name = "picTreinos";
            picTreinos.Size = new Size(86, 64);
            picTreinos.SizeMode = PictureBoxSizeMode.Zoom;
            picTreinos.TabIndex = 9;
            picTreinos.TabStop = false;
            // 
            // lblTotalTreinos
            // 
            lblTotalTreinos.Font = new Font("Segoe UI", 20F);
            lblTotalTreinos.ForeColor = Color.FromArgb(219, 39, 119);
            lblTotalTreinos.Location = new Point(113, 82);
            lblTotalTreinos.Name = "lblTotalTreinos";
            lblTotalTreinos.Size = new Size(30, 50);
            lblTotalTreinos.TabIndex = 2;
            lblTotalTreinos.Text = "0";
            lblTotalTreinos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloTreinos
            // 
            lblTituloTreinos.AutoSize = true;
            lblTituloTreinos.Font = new Font("Segoe UI", 14F);
            lblTituloTreinos.ForeColor = Color.MediumVioletRed;
            lblTituloTreinos.Location = new Point(85, 132);
            lblTituloTreinos.Name = "lblTituloTreinos";
            lblTituloTreinos.Size = new Size(86, 25);
            lblTituloTreinos.TabIndex = 0;
            lblTituloTreinos.Text = "TREINOS";
            lblTituloTreinos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelExercicios
            // 
            panelExercicios.BackColor = Color.White;
            panelExercicios.Controls.Add(picExercicios);
            panelExercicios.Controls.Add(label1);
            panelExercicios.Controls.Add(lblTotalExercicios);
            panelExercicios.Controls.Add(lblTituloExercicios);
            panelExercicios.ForeColor = Color.FromArgb(219, 39, 119);
            panelExercicios.Location = new Point(288, 8);
            panelExercicios.Margin = new Padding(8);
            panelExercicios.Name = "panelExercicios";
            panelExercicios.Size = new Size(264, 213);
            panelExercicios.TabIndex = 4;
            // 
            // picExercicios
            // 
            picExercicios.BackgroundImageLayout = ImageLayout.Stretch;
            picExercicios.Image = Properties.Resources.Ícone_de_haltere_rosa_vibrante;
            picExercicios.InitialImage = Properties.Resources.Ícone_de_haltere_rosa_vibrante;
            picExercicios.Location = new Point(95, 15);
            picExercicios.Name = "picExercicios";
            picExercicios.Size = new Size(85, 75);
            picExercicios.SizeMode = PictureBoxSizeMode.Zoom;
            picExercicios.TabIndex = 8;
            picExercicios.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(85, 177);
            label1.Name = "label1";
            label1.Size = new Size(109, 19);
            label1.TabIndex = 3;
            label1.Text = "Total cadastrado";
            // 
            // lblTotalExercicios
            // 
            lblTotalExercicios.Font = new Font("Segoe UI", 20F);
            lblTotalExercicios.ForeColor = Color.FromArgb(219, 39, 119);
            lblTotalExercicios.Location = new Point(124, 82);
            lblTotalExercicios.Name = "lblTotalExercicios";
            lblTotalExercicios.Size = new Size(27, 50);
            lblTotalExercicios.TabIndex = 2;
            lblTotalExercicios.Text = "0";
            lblTotalExercicios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloExercicios
            // 
            lblTituloExercicios.AutoSize = true;
            lblTituloExercicios.Font = new Font("Segoe UI", 14F);
            lblTituloExercicios.ForeColor = Color.MediumVioletRed;
            lblTituloExercicios.Location = new Point(85, 132);
            lblTituloExercicios.Name = "lblTituloExercicios";
            lblTituloExercicios.Size = new Size(112, 25);
            lblTituloExercicios.TabIndex = 0;
            lblTituloExercicios.Text = "EXERCÍCIOS";
            lblTituloExercicios.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelAlunos
            // 
            panelAlunos.BackColor = Color.White;
            panelAlunos.Controls.Add(picAlunos);
            panelAlunos.Controls.Add(lblPainel);
            panelAlunos.Controls.Add(lblTotalAlunos);
            panelAlunos.Controls.Add(lblTituloAlunos);
            panelAlunos.ForeColor = Color.FromArgb(219, 39, 119);
            panelAlunos.Location = new Point(8, 8);
            panelAlunos.Margin = new Padding(8);
            panelAlunos.Name = "panelAlunos";
            panelAlunos.Size = new Size(264, 213);
            panelAlunos.TabIndex = 3;
            // 
            // picAlunos
            // 
            picAlunos.BackgroundImageLayout = ImageLayout.Stretch;
            picAlunos.Image = Properties.Resources.Ícone_minimalista_de_duas_pessoas_em_magenta;
            picAlunos.InitialImage = null;
            picAlunos.Location = new Point(83, 15);
            picAlunos.Name = "picAlunos";
            picAlunos.Size = new Size(84, 75);
            picAlunos.SizeMode = PictureBoxSizeMode.Zoom;
            picAlunos.TabIndex = 7;
            picAlunos.TabStop = false;
            // 
            // lblPainel
            // 
            lblPainel.AutoSize = true;
            lblPainel.Font = new Font("Segoe UI", 10F);
            lblPainel.Location = new Point(72, 177);
            lblPainel.Name = "lblPainel";
            lblPainel.Size = new Size(109, 19);
            lblPainel.TabIndex = 2;
            lblPainel.Text = "Total cadastrado";
            // 
            // lblTotalAlunos
            // 
            lblTotalAlunos.Font = new Font("Segoe UI", 20F);
            lblTotalAlunos.ForeColor = Color.FromArgb(219, 39, 119);
            lblTotalAlunos.Location = new Point(112, 82);
            lblTotalAlunos.Name = "lblTotalAlunos";
            lblTotalAlunos.Size = new Size(27, 50);
            lblTotalAlunos.TabIndex = 1;
            lblTotalAlunos.Text = "0";
            lblTotalAlunos.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTituloAlunos
            // 
            lblTituloAlunos.AutoSize = true;
            lblTituloAlunos.Font = new Font("Segoe UI", 14F);
            lblTituloAlunos.ForeColor = Color.MediumVioletRed;
            lblTituloAlunos.Location = new Point(83, 132);
            lblTituloAlunos.Name = "lblTituloAlunos";
            lblTituloAlunos.Size = new Size(84, 25);
            lblTituloAlunos.TabIndex = 0;
            lblTituloAlunos.Text = "ALUNOS";
            lblTituloAlunos.TextAlign = ContentAlignment.MiddleCenter;
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
            pictureBoxKitty.Size = new Size(1152, 321);
            pictureBoxKitty.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxKitty.TabIndex = 3;
            pictureBoxKitty.TabStop = false;
            // 
            // FormDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 242, 248);
            ClientSize = new Size(1179, 633);
            Controls.Add(pictureBoxKitty);
            Controls.Add(lblTitulo);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormDashboard";
            StartPosition = FormStartPosition.Manual;
            Text = "Dashboard";
            tableLayoutPanel1.ResumeLayout(false);
            panelAvaliacoes.ResumeLayout(false);
            panelAvaliacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAvaliacoes).EndInit();
            panelTreinos.ResumeLayout(false);
            panelTreinos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picTreinos).EndInit();
            panelExercicios.ResumeLayout(false);
            panelExercicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picExercicios).EndInit();
            panelAlunos.ResumeLayout(false);
            panelAlunos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picAlunos).EndInit();
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
        private Label label3;
        private Label label1;
        private Label lblPainel;
        private PictureBox picAvaliacoes;
        private PictureBox picTreinos;
        private PictureBox picExercicios;
        private PictureBox picAlunos;
        private Label label2;
    }
}