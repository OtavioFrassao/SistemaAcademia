using System;
using System.Drawing;
using System.Windows.Forms;

namespace AcademiaApp
{
    partial class FormPerfilAluno
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            layoutAvaliacoes = new TableLayoutPanel();
            lblTituloAvaliacoes = new Label();
            dgvAvaliacoesPerfil = new DataGridView();
            lblResumoAvaliacoes = new Label();
            layoutTreinos = new TableLayoutPanel();
            lblTituloTreinos = new Label();
            dgvTreinosPerfil = new DataGridView();
            lblTituloExercicios = new Label();
            dgvItensPerfil = new DataGridView();
            btnGerarPdf = new Button();
            panelCabecalho = new Panel();
            pictureBoxAluno = new PictureBox();
            lblNomeAluno = new Label();
            lblIdAluno = new Label();
            lblAcademia = new Label();
            tabControlPerfil = new TabControl();
            tabDadosPessoais = new TabPage();
            lblTituloDados = new Label();
            panelNome = new Panel();
            lblTituloNome = new Label();
            lblNomeCompleto = new Label();
            panelCPF = new Panel();
            lblTituloCPF = new Label();
            lblCPF = new Label();
            panelNascimento = new Panel();
            lblTituloNascimento = new Label();
            lblNascimento = new Label();
            panelTelefone = new Panel();
            lblTituloTelefone = new Label();
            lblTelefone = new Label();
            panelEmail = new Panel();
            lblTituloEmail = new Label();
            lblEmail = new Label();
            panelCodigo = new Panel();
            lblTituloCodigo = new Label();
            lblCodigoAluno = new Label();
            tabTreinos = new TabPage();
            tabAvaliacoes = new TabPage();
            layoutAvaliacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvaliacoesPerfil).BeginInit();
            layoutTreinos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTreinosPerfil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensPerfil).BeginInit();
            panelCabecalho.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAluno).BeginInit();
            tabControlPerfil.SuspendLayout();
            tabDadosPessoais.SuspendLayout();
            panelNome.SuspendLayout();
            panelCPF.SuspendLayout();
            panelNascimento.SuspendLayout();
            panelTelefone.SuspendLayout();
            panelEmail.SuspendLayout();
            panelCodigo.SuspendLayout();
            tabTreinos.SuspendLayout();
            tabAvaliacoes.SuspendLayout();
            SuspendLayout();
            // 
            // layoutAvaliacoes
            // 
            layoutAvaliacoes.BackColor = Color.White;
            layoutAvaliacoes.ColumnCount = 1;
            layoutAvaliacoes.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutAvaliacoes.Controls.Add(lblTituloAvaliacoes, 0, 0);
            layoutAvaliacoes.Controls.Add(dgvAvaliacoesPerfil, 0, 1);
            layoutAvaliacoes.Controls.Add(lblResumoAvaliacoes, 0, 2);
            layoutAvaliacoes.Dock = DockStyle.Fill;
            layoutAvaliacoes.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            layoutAvaliacoes.Location = new Point(3, 3);
            layoutAvaliacoes.Name = "layoutAvaliacoes";
            layoutAvaliacoes.Padding = new Padding(18, 12, 18, 16);
            layoutAvaliacoes.RowCount = 3;
            layoutAvaliacoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            layoutAvaliacoes.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutAvaliacoes.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            layoutAvaliacoes.Size = new Size(936, 431);
            layoutAvaliacoes.TabIndex = 0;
            // 
            // lblTituloAvaliacoes
            // 
            lblTituloAvaliacoes.Dock = DockStyle.Fill;
            lblTituloAvaliacoes.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloAvaliacoes.ForeColor = Color.FromArgb(190, 24, 93);
            lblTituloAvaliacoes.Location = new Point(18, 12);
            lblTituloAvaliacoes.Margin = new Padding(0);
            lblTituloAvaliacoes.Name = "lblTituloAvaliacoes";
            lblTituloAvaliacoes.Size = new Size(900, 38);
            lblTituloAvaliacoes.TabIndex = 0;
            lblTituloAvaliacoes.Text = "Histórico de avaliações físicas";
            lblTituloAvaliacoes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvAvaliacoesPerfil
            // 
            dgvAvaliacoesPerfil.AllowUserToAddRows = false;
            dgvAvaliacoesPerfil.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(253, 242, 248);
            dgvAvaliacoesPerfil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvAvaliacoesPerfil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAvaliacoesPerfil.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAvaliacoesPerfil.BackgroundColor = Color.White;
            dgvAvaliacoesPerfil.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(252, 231, 243);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(157, 23, 77);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(252, 231, 243);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(157, 23, 77);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvAvaliacoesPerfil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvAvaliacoesPerfil.ColumnHeadersHeight = 32;
            dgvAvaliacoesPerfil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(236, 72, 153);
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvAvaliacoesPerfil.DefaultCellStyle = dataGridViewCellStyle3;
            dgvAvaliacoesPerfil.Dock = DockStyle.Fill;
            dgvAvaliacoesPerfil.EnableHeadersVisualStyles = false;
            dgvAvaliacoesPerfil.GridColor = Color.FromArgb(251, 207, 232);
            dgvAvaliacoesPerfil.Location = new Point(18, 50);
            dgvAvaliacoesPerfil.Margin = new Padding(0);
            dgvAvaliacoesPerfil.MultiSelect = false;
            dgvAvaliacoesPerfil.Name = "dgvAvaliacoesPerfil";
            dgvAvaliacoesPerfil.ReadOnly = true;
            dgvAvaliacoesPerfil.RowHeadersVisible = false;
            dgvAvaliacoesPerfil.RowTemplate.Height = 30;
            dgvAvaliacoesPerfil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAvaliacoesPerfil.Size = new Size(900, 333);
            dgvAvaliacoesPerfil.TabIndex = 1;
            // 
            // lblResumoAvaliacoes
            // 
            lblResumoAvaliacoes.Dock = DockStyle.Fill;
            lblResumoAvaliacoes.Font = new Font("Segoe UI", 10F);
            lblResumoAvaliacoes.ForeColor = Color.FromArgb(190, 24, 93);
            lblResumoAvaliacoes.Location = new Point(18, 387);
            lblResumoAvaliacoes.Margin = new Padding(0, 4, 0, 0);
            lblResumoAvaliacoes.Name = "lblResumoAvaliacoes";
            lblResumoAvaliacoes.Size = new Size(900, 28);
            lblResumoAvaliacoes.TabIndex = 2;
            lblResumoAvaliacoes.Text = "Total de avaliações: —";
            lblResumoAvaliacoes.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // layoutTreinos
            // 
            layoutTreinos.BackColor = Color.White;
            layoutTreinos.ColumnCount = 1;
            layoutTreinos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            layoutTreinos.Controls.Add(lblTituloTreinos, 0, 0);
            layoutTreinos.Controls.Add(dgvTreinosPerfil, 0, 1);
            layoutTreinos.Controls.Add(lblTituloExercicios, 0, 2);
            layoutTreinos.Controls.Add(dgvItensPerfil, 0, 3);
            layoutTreinos.Controls.Add(btnGerarPdf, 0, 4);
            layoutTreinos.Dock = DockStyle.Fill;
            layoutTreinos.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            layoutTreinos.Location = new Point(3, 3);
            layoutTreinos.Name = "layoutTreinos";
            layoutTreinos.Padding = new Padding(18, 12, 18, 16);
            layoutTreinos.RowCount = 5;
            layoutTreinos.RowStyles.Add(new RowStyle(SizeType.Absolute, 36F));
            layoutTreinos.RowStyles.Add(new RowStyle(SizeType.Absolute, 137F));
            layoutTreinos.RowStyles.Add(new RowStyle(SizeType.Absolute, 42F));
            layoutTreinos.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            layoutTreinos.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            layoutTreinos.Size = new Size(936, 431);
            layoutTreinos.TabIndex = 0;
            // 
            // lblTituloTreinos
            // 
            lblTituloTreinos.Dock = DockStyle.Fill;
            lblTituloTreinos.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloTreinos.ForeColor = Color.FromArgb(190, 24, 93);
            lblTituloTreinos.Location = new Point(18, 12);
            lblTituloTreinos.Margin = new Padding(0);
            lblTituloTreinos.Name = "lblTituloTreinos";
            lblTituloTreinos.Size = new Size(900, 36);
            lblTituloTreinos.TabIndex = 0;
            lblTituloTreinos.Text = "Treinos cadastrados";
            lblTituloTreinos.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvTreinosPerfil
            // 
            dgvTreinosPerfil.AllowUserToAddRows = false;
            dgvTreinosPerfil.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(253, 242, 248);
            dgvTreinosPerfil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTreinosPerfil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTreinosPerfil.BackgroundColor = Color.White;
            dgvTreinosPerfil.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(252, 231, 243);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(157, 23, 77);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(252, 231, 243);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(157, 23, 77);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.True;
            dgvTreinosPerfil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dgvTreinosPerfil.ColumnHeadersHeight = 32;
            dgvTreinosPerfil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.White;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(236, 72, 153);
            dataGridViewCellStyle6.SelectionForeColor = Color.White;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            dgvTreinosPerfil.DefaultCellStyle = dataGridViewCellStyle6;
            dgvTreinosPerfil.Dock = DockStyle.Fill;
            dgvTreinosPerfil.EnableHeadersVisualStyles = false;
            dgvTreinosPerfil.GridColor = Color.FromArgb(251, 207, 232);
            dgvTreinosPerfil.Location = new Point(18, 48);
            dgvTreinosPerfil.Margin = new Padding(0);
            dgvTreinosPerfil.MultiSelect = false;
            dgvTreinosPerfil.Name = "dgvTreinosPerfil";
            dgvTreinosPerfil.ReadOnly = true;
            dgvTreinosPerfil.RowHeadersVisible = false;
            dgvTreinosPerfil.RowTemplate.Height = 30;
            dgvTreinosPerfil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTreinosPerfil.Size = new Size(900, 137);
            dgvTreinosPerfil.TabIndex = 1;
            // 
            // lblTituloExercicios
            // 
            lblTituloExercicios.Dock = DockStyle.Fill;
            lblTituloExercicios.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTituloExercicios.ForeColor = Color.FromArgb(190, 24, 93);
            lblTituloExercicios.Location = new Point(18, 185);
            lblTituloExercicios.Margin = new Padding(0);
            lblTituloExercicios.Name = "lblTituloExercicios";
            lblTituloExercicios.Size = new Size(900, 42);
            lblTituloExercicios.TabIndex = 2;
            lblTituloExercicios.Text = "Exercícios do treino selecionado";
            lblTituloExercicios.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dgvItensPerfil
            // 
            dgvItensPerfil.AllowUserToAddRows = false;
            dgvItensPerfil.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(253, 242, 248);
            dgvItensPerfil.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            dgvItensPerfil.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItensPerfil.BackgroundColor = Color.White;
            dgvItensPerfil.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(252, 231, 243);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(157, 23, 77);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(252, 231, 243);
            dataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(157, 23, 77);
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dgvItensPerfil.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dgvItensPerfil.ColumnHeadersHeight = 32;
            dgvItensPerfil.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.White;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 10F);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(236, 72, 153);
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dgvItensPerfil.DefaultCellStyle = dataGridViewCellStyle9;
            dgvItensPerfil.Dock = DockStyle.Fill;
            dgvItensPerfil.EnableHeadersVisualStyles = false;
            dgvItensPerfil.GridColor = Color.FromArgb(251, 207, 232);
            dgvItensPerfil.Location = new Point(18, 227);
            dgvItensPerfil.Margin = new Padding(0);
            dgvItensPerfil.MultiSelect = false;
            dgvItensPerfil.Name = "dgvItensPerfil";
            dgvItensPerfil.ReadOnly = true;
            dgvItensPerfil.RowHeadersVisible = false;
            dgvItensPerfil.RowTemplate.Height = 30;
            dgvItensPerfil.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensPerfil.Size = new Size(900, 140);
            dgvItensPerfil.TabIndex = 3;
            // 
            // btnGerarPdf
            // 
            btnGerarPdf.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnGerarPdf.BackColor = Color.FromArgb(190, 24, 93);
            btnGerarPdf.Cursor = Cursors.Hand;
            btnGerarPdf.Enabled = false;
            btnGerarPdf.FlatAppearance.BorderSize = 0;
            btnGerarPdf.FlatStyle = FlatStyle.Flat;
            btnGerarPdf.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnGerarPdf.ForeColor = Color.White;
            btnGerarPdf.Location = new Point(758, 377);
            btnGerarPdf.Margin = new Padding(0, 8, 0, 0);
            btnGerarPdf.Name = "btnGerarPdf";
            btnGerarPdf.Size = new Size(160, 38);
            btnGerarPdf.TabIndex = 4;
            btnGerarPdf.Text = "GERAR PDF";
            btnGerarPdf.UseVisualStyleBackColor = true;
            // 
            // panelCabecalho
            // 
            panelCabecalho.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panelCabecalho.BackColor = Color.White;
            panelCabecalho.Controls.Add(pictureBoxAluno);
            panelCabecalho.Controls.Add(lblNomeAluno);
            panelCabecalho.Controls.Add(lblIdAluno);
            panelCabecalho.Controls.Add(lblAcademia);
            panelCabecalho.Location = new Point(15, 15);
            panelCabecalho.Name = "panelCabecalho";
            panelCabecalho.Size = new Size(950, 120);
            panelCabecalho.TabIndex = 1;
            // 
            // pictureBoxAluno
            // 
            pictureBoxAluno.BackColor = Color.White;
            pictureBoxAluno.Image = Properties.Resources.Ícone_circular_de_gatinha_rosa;
            pictureBoxAluno.Location = new Point(4, 3);
            pictureBoxAluno.Name = "pictureBoxAluno";
            pictureBoxAluno.Size = new Size(135, 114);
            pictureBoxAluno.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAluno.TabIndex = 0;
            pictureBoxAluno.TabStop = false;
            // 
            // lblNomeAluno
            // 
            lblNomeAluno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeAluno.AutoEllipsis = true;
            lblNomeAluno.BackColor = Color.Transparent;
            lblNomeAluno.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            lblNomeAluno.ForeColor = Color.FromArgb(190, 24, 93);
            lblNomeAluno.Location = new Point(135, 15);
            lblNomeAluno.Name = "lblNomeAluno";
            lblNomeAluno.Size = new Size(780, 38);
            lblNomeAluno.TabIndex = 1;
            lblNomeAluno.Text = "Nome do Aluno";
            lblNomeAluno.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblIdAluno
            // 
            lblIdAluno.AutoSize = true;
            lblIdAluno.BackColor = Color.Transparent;
            lblIdAluno.Font = new Font("Segoe UI", 12F);
            lblIdAluno.ForeColor = Color.FromArgb(219, 39, 119);
            lblIdAluno.Location = new Point(135, 57);
            lblIdAluno.Name = "lblIdAluno";
            lblIdAluno.Size = new Size(91, 21);
            lblIdAluno.TabIndex = 2;
            lblIdAluno.Text = "Aluno #000";
            // 
            // lblAcademia
            // 
            lblAcademia.AutoSize = true;
            lblAcademia.BackColor = Color.Transparent;
            lblAcademia.Font = new Font("Segoe UI", 10F);
            lblAcademia.ForeColor = Color.FromArgb(219, 39, 119);
            lblAcademia.Location = new Point(135, 87);
            lblAcademia.Name = "lblAcademia";
            lblAcademia.Size = new Size(105, 19);
            lblAcademia.TabIndex = 3;
            lblAcademia.Text = "Hello Kitty Gym";
            // 
            // tabControlPerfil
            // 
            tabControlPerfil.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlPerfil.Controls.Add(tabDadosPessoais);
            tabControlPerfil.Controls.Add(tabTreinos);
            tabControlPerfil.Controls.Add(tabAvaliacoes);
            tabControlPerfil.Font = new Font("Segoe UI", 11F);
            tabControlPerfil.Location = new Point(15, 150);
            tabControlPerfil.Name = "tabControlPerfil";
            tabControlPerfil.SelectedIndex = 0;
            tabControlPerfil.Size = new Size(950, 470);
            tabControlPerfil.TabIndex = 0;
            // 
            // tabDadosPessoais
            // 
            tabDadosPessoais.BackColor = Color.White;
            tabDadosPessoais.Controls.Add(lblTituloDados);
            tabDadosPessoais.Controls.Add(panelNome);
            tabDadosPessoais.Controls.Add(panelCPF);
            tabDadosPessoais.Controls.Add(panelNascimento);
            tabDadosPessoais.Controls.Add(panelTelefone);
            tabDadosPessoais.Controls.Add(panelEmail);
            tabDadosPessoais.Controls.Add(panelCodigo);
            tabDadosPessoais.Location = new Point(4, 29);
            tabDadosPessoais.Name = "tabDadosPessoais";
            tabDadosPessoais.Padding = new Padding(3);
            tabDadosPessoais.Size = new Size(942, 437);
            tabDadosPessoais.TabIndex = 0;
            tabDadosPessoais.Text = "Dados pessoais";
            // 
            // lblTituloDados
            // 
            lblTituloDados.AutoSize = true;
            lblTituloDados.BackColor = Color.Transparent;
            lblTituloDados.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTituloDados.ForeColor = Color.FromArgb(190, 24, 93);
            lblTituloDados.Location = new Point(20, 15);
            lblTituloDados.Name = "lblTituloDados";
            lblTituloDados.Size = new Size(278, 32);
            lblTituloDados.TabIndex = 0;
            lblTituloDados.Text = "Informações cadastrais";
            // 
            // panelNome
            // 
            panelNome.BackColor = Color.FromArgb(253, 242, 248);
            panelNome.Controls.Add(lblTituloNome);
            panelNome.Controls.Add(lblNomeCompleto);
            panelNome.Location = new Point(20, 65);
            panelNome.Name = "panelNome";
            panelNome.Size = new Size(430, 90);
            panelNome.TabIndex = 1;
            // 
            // lblTituloNome
            // 
            lblTituloNome.AutoSize = true;
            lblTituloNome.BackColor = Color.Transparent;
            lblTituloNome.Font = new Font("Segoe UI", 11F);
            lblTituloNome.ForeColor = Color.FromArgb(190, 24, 93);
            lblTituloNome.Location = new Point(15, 10);
            lblTituloNome.Name = "lblTituloNome";
            lblTituloNome.Size = new Size(118, 20);
            lblTituloNome.TabIndex = 0;
            lblTituloNome.Text = "Nome completo";
            // 
            // lblNomeCompleto
            // 
            lblNomeCompleto.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNomeCompleto.AutoEllipsis = true;
            lblNomeCompleto.BackColor = Color.Transparent;
            lblNomeCompleto.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNomeCompleto.ForeColor = Color.FromArgb(64, 64, 64);
            lblNomeCompleto.Location = new Point(15, 40);
            lblNomeCompleto.Name = "lblNomeCompleto";
            lblNomeCompleto.Size = new Size(400, 36);
            lblNomeCompleto.TabIndex = 1;
            lblNomeCompleto.Text = "—";
            lblNomeCompleto.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCPF
            // 
            panelCPF.BackColor = Color.FromArgb(253, 242, 248);
            panelCPF.Controls.Add(lblTituloCPF);
            panelCPF.Controls.Add(lblCPF);
            panelCPF.Location = new Point(470, 65);
            panelCPF.Name = "panelCPF";
            panelCPF.Size = new Size(430, 90);
            panelCPF.TabIndex = 2;
            // 
            // lblTituloCPF
            // 
            lblTituloCPF.AutoSize = true;
            lblTituloCPF.BackColor = Color.Transparent;
            lblTituloCPF.Font = new Font("Segoe UI", 11F);
            lblTituloCPF.ForeColor = Color.FromArgb(190, 24, 93);
            lblTituloCPF.Location = new Point(15, 10);
            lblTituloCPF.Name = "lblTituloCPF";
            lblTituloCPF.Size = new Size(33, 20);
            lblTituloCPF.TabIndex = 0;
            lblTituloCPF.Text = "CPF";
            // 
            // lblCPF
            // 
            lblCPF.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCPF.AutoEllipsis = true;
            lblCPF.BackColor = Color.Transparent;
            lblCPF.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCPF.ForeColor = Color.FromArgb(64, 64, 64);
            lblCPF.Location = new Point(15, 40);
            lblCPF.Name = "lblCPF";
            lblCPF.Size = new Size(400, 36);
            lblCPF.TabIndex = 1;
            lblCPF.Text = "—";
            lblCPF.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelNascimento
            // 
            panelNascimento.BackColor = Color.FromArgb(253, 242, 248);
            panelNascimento.Controls.Add(lblTituloNascimento);
            panelNascimento.Controls.Add(lblNascimento);
            panelNascimento.Location = new Point(20, 175);
            panelNascimento.Name = "panelNascimento";
            panelNascimento.Size = new Size(430, 90);
            panelNascimento.TabIndex = 3;
            // 
            // lblTituloNascimento
            // 
            lblTituloNascimento.AutoSize = true;
            lblTituloNascimento.BackColor = Color.Transparent;
            lblTituloNascimento.Font = new Font("Segoe UI", 11F);
            lblTituloNascimento.ForeColor = Color.FromArgb(190, 24, 93);
            lblTituloNascimento.Location = new Point(15, 10);
            lblTituloNascimento.Name = "lblTituloNascimento";
            lblTituloNascimento.Size = new Size(142, 20);
            lblTituloNascimento.TabIndex = 0;
            lblTituloNascimento.Text = "Data de nascimento";
            // 
            // lblNascimento
            // 
            lblNascimento.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblNascimento.AutoEllipsis = true;
            lblNascimento.BackColor = Color.Transparent;
            lblNascimento.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblNascimento.ForeColor = Color.FromArgb(64, 64, 64);
            lblNascimento.Location = new Point(15, 40);
            lblNascimento.Name = "lblNascimento";
            lblNascimento.Size = new Size(400, 36);
            lblNascimento.TabIndex = 1;
            lblNascimento.Text = "—";
            lblNascimento.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelTelefone
            // 
            panelTelefone.BackColor = Color.FromArgb(253, 242, 248);
            panelTelefone.Controls.Add(lblTituloTelefone);
            panelTelefone.Controls.Add(lblTelefone);
            panelTelefone.Location = new Point(470, 175);
            panelTelefone.Name = "panelTelefone";
            panelTelefone.Size = new Size(430, 90);
            panelTelefone.TabIndex = 4;
            // 
            // lblTituloTelefone
            // 
            lblTituloTelefone.AutoSize = true;
            lblTituloTelefone.BackColor = Color.Transparent;
            lblTituloTelefone.Font = new Font("Segoe UI", 11F);
            lblTituloTelefone.ForeColor = Color.FromArgb(190, 24, 93);
            lblTituloTelefone.Location = new Point(15, 10);
            lblTituloTelefone.Name = "lblTituloTelefone";
            lblTituloTelefone.Size = new Size(66, 20);
            lblTituloTelefone.TabIndex = 0;
            lblTituloTelefone.Text = "Telefone";
            // 
            // lblTelefone
            // 
            lblTelefone.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTelefone.AutoEllipsis = true;
            lblTelefone.BackColor = Color.Transparent;
            lblTelefone.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTelefone.ForeColor = Color.FromArgb(64, 64, 64);
            lblTelefone.Location = new Point(15, 40);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(400, 36);
            lblTelefone.TabIndex = 1;
            lblTelefone.Text = "—";
            lblTelefone.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = Color.FromArgb(253, 242, 248);
            panelEmail.Controls.Add(lblTituloEmail);
            panelEmail.Controls.Add(lblEmail);
            panelEmail.Location = new Point(20, 285);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(430, 90);
            panelEmail.TabIndex = 5;
            // 
            // lblTituloEmail
            // 
            lblTituloEmail.AutoSize = true;
            lblTituloEmail.BackColor = Color.Transparent;
            lblTituloEmail.Font = new Font("Segoe UI", 11F);
            lblTituloEmail.ForeColor = Color.FromArgb(190, 24, 93);
            lblTituloEmail.Location = new Point(15, 10);
            lblTituloEmail.Name = "lblTituloEmail";
            lblTituloEmail.Size = new Size(52, 20);
            lblTituloEmail.TabIndex = 0;
            lblTituloEmail.Text = "E-mail";
            // 
            // lblEmail
            // 
            lblEmail.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmail.AutoEllipsis = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(15, 40);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(400, 36);
            lblEmail.TabIndex = 1;
            lblEmail.Text = "—";
            lblEmail.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelCodigo
            // 
            panelCodigo.BackColor = Color.FromArgb(253, 242, 248);
            panelCodigo.Controls.Add(lblTituloCodigo);
            panelCodigo.Controls.Add(lblCodigoAluno);
            panelCodigo.Location = new Point(470, 285);
            panelCodigo.Name = "panelCodigo";
            panelCodigo.Size = new Size(430, 90);
            panelCodigo.TabIndex = 6;
            // 
            // lblTituloCodigo
            // 
            lblTituloCodigo.AutoSize = true;
            lblTituloCodigo.BackColor = Color.Transparent;
            lblTituloCodigo.Font = new Font("Segoe UI", 11F);
            lblTituloCodigo.ForeColor = Color.FromArgb(190, 24, 93);
            lblTituloCodigo.Location = new Point(15, 10);
            lblTituloCodigo.Name = "lblTituloCodigo";
            lblTituloCodigo.Size = new Size(121, 20);
            lblTituloCodigo.TabIndex = 0;
            lblTituloCodigo.Text = "Código do aluno";
            // 
            // lblCodigoAluno
            // 
            lblCodigoAluno.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblCodigoAluno.AutoEllipsis = true;
            lblCodigoAluno.BackColor = Color.Transparent;
            lblCodigoAluno.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblCodigoAluno.ForeColor = Color.FromArgb(64, 64, 64);
            lblCodigoAluno.Location = new Point(15, 40);
            lblCodigoAluno.Name = "lblCodigoAluno";
            lblCodigoAluno.Size = new Size(400, 36);
            lblCodigoAluno.TabIndex = 1;
            lblCodigoAluno.Text = "—";
            lblCodigoAluno.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabTreinos
            // 
            tabTreinos.BackColor = Color.White;
            tabTreinos.Controls.Add(layoutTreinos);
            tabTreinos.Location = new Point(4, 29);
            tabTreinos.Name = "tabTreinos";
            tabTreinos.Padding = new Padding(3);
            tabTreinos.Size = new Size(942, 437);
            tabTreinos.TabIndex = 1;
            tabTreinos.Text = "Treinos";
            // 
            // tabAvaliacoes
            // 
            tabAvaliacoes.BackColor = Color.White;
            tabAvaliacoes.Controls.Add(layoutAvaliacoes);
            tabAvaliacoes.Location = new Point(4, 29);
            tabAvaliacoes.Name = "tabAvaliacoes";
            tabAvaliacoes.Padding = new Padding(3);
            tabAvaliacoes.Size = new Size(942, 437);
            tabAvaliacoes.TabIndex = 2;
            tabAvaliacoes.Text = "Avaliações físicas";
            // 
            // FormPerfilAluno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(253, 242, 248);
            ClientSize = new Size(984, 661);
            Controls.Add(tabControlPerfil);
            Controls.Add(panelCabecalho);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormPerfilAluno";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Perfil Completo do Aluno";
            layoutAvaliacoes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvAvaliacoesPerfil).EndInit();
            layoutTreinos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTreinosPerfil).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvItensPerfil).EndInit();
            panelCabecalho.ResumeLayout(false);
            panelCabecalho.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAluno).EndInit();
            tabControlPerfil.ResumeLayout(false);
            tabDadosPessoais.ResumeLayout(false);
            tabDadosPessoais.PerformLayout();
            panelNome.ResumeLayout(false);
            panelNome.PerformLayout();
            panelCPF.ResumeLayout(false);
            panelCPF.PerformLayout();
            panelNascimento.ResumeLayout(false);
            panelNascimento.PerformLayout();
            panelTelefone.ResumeLayout(false);
            panelTelefone.PerformLayout();
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            panelCodigo.ResumeLayout(false);
            panelCodigo.PerformLayout();
            tabTreinos.ResumeLayout(false);
            tabAvaliacoes.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel layoutAvaliacoes;
        private Label lblTituloAvaliacoes;
        private Label lblResumoAvaliacoes;
        private DataGridView dgvAvaliacoesPerfil;
        private DataGridViewTextBoxColumn colAvaliacaoID;
        private DataGridViewTextBoxColumn colAvaliacaoData;
        private DataGridViewTextBoxColumn colAvaliacaoPeso;
        private DataGridViewTextBoxColumn colAvaliacaoAltura;
        private DataGridViewTextBoxColumn colAvaliacaoGordura;
        private DataGridViewTextBoxColumn colAvaliacaoObservacao;
        private TableLayoutPanel layoutTreinos;
        private Button btnGerarPdf;
        private Label lblTituloTreinos;
        private Label lblTituloExercicios;
        private DataGridView dgvTreinosPerfil;
        private DataGridView dgvItensPerfil;
        private DataGridViewTextBoxColumn colTreinoID;
        private DataGridViewTextBoxColumn colTreinoNome;
        private DataGridViewTextBoxColumn colTreinoDescricao;
        private DataGridViewTextBoxColumn colTreinoInicio;
        private DataGridViewTextBoxColumn colTreinoFim;
        private DataGridViewTextBoxColumn colItemExercicio;
        private DataGridViewTextBoxColumn colItemSeries;
        private DataGridViewTextBoxColumn colItemRepeticoes;
        private DataGridViewTextBoxColumn colItemCarga;
        private Panel panelCabecalho;
        private PictureBox pictureBoxAluno;
        private Label lblNomeAluno;
        private Label lblIdAluno;
        private Label lblAcademia;
        private TabControl tabControlPerfil;
        private TabPage tabDadosPessoais;
        private TabPage tabTreinos;
        private TabPage tabAvaliacoes;
        private Label lblTituloDados;
        private Panel panelNome;
        private Label lblTituloNome;
        private Label lblNomeCompleto;
        private Panel panelCPF;
        private Label lblTituloCPF;
        private Label lblCPF;
        private Panel panelNascimento;
        private Label lblTituloNascimento;
        private Label lblNascimento;
        private Panel panelTelefone;
        private Label lblTituloTelefone;
        private Label lblTelefone;
        private Panel panelEmail;
        private Label lblTituloEmail;
        private Label lblEmail;
        private Panel panelCodigo;
        private Label lblTituloCodigo;
        private Label lblCodigoAluno;
    }
}
