namespace AcademiaApp.Cadastros
{
    partial class CadastroItemTreino
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
            cboTreino = new ReaLTaiizor.Controls.MaterialComboBox();
            cboExercicio = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSeries = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtRepeticoes = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtCarga = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            dgvItensTemporarios = new DataGridView();
            btnAdicionar = new ReaLTaiizor.Controls.MaterialButton();
            TabControlCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensTemporarios).BeginInit();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(794, 383);
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(702, 304);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(598, 304);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnAdicionar);
            tabPageCadastro.Controls.Add(dgvItensTemporarios);
            tabPageCadastro.Controls.Add(txtCarga);
            tabPageCadastro.Controls.Add(txtRepeticoes);
            tabPageCadastro.Controls.Add(txtSeries);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboExercicio);
            tabPageCadastro.Controls.Add(cboTreino);
            tabPageCadastro.Size = new Size(786, 355);
            tabPageCadastro.Controls.SetChildIndex(buttonCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(cboTreino, 0);
            tabPageCadastro.Controls.SetChildIndex(cboExercicio, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtSeries, 0);
            tabPageCadastro.Controls.SetChildIndex(txtRepeticoes, 0);
            tabPageCadastro.Controls.SetChildIndex(txtCarga, 0);
            tabPageCadastro.Controls.SetChildIndex(dgvItensTemporarios, 0);
            tabPageCadastro.Controls.SetChildIndex(btnAdicionar, 0);
            // 
            // cboTreino
            // 
            cboTreino.AutoResize = false;
            cboTreino.BackColor = Color.FromArgb(255, 255, 255);
            cboTreino.Depth = 0;
            cboTreino.DrawMode = DrawMode.OwnerDrawVariable;
            cboTreino.DropDownHeight = 174;
            cboTreino.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTreino.DropDownWidth = 121;
            cboTreino.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboTreino.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboTreino.FormattingEnabled = true;
            cboTreino.Hint = "Treino";
            cboTreino.IntegralHeight = false;
            cboTreino.ItemHeight = 43;
            cboTreino.Location = new Point(395, 6);
            cboTreino.MaxDropDownItems = 4;
            cboTreino.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboTreino.Name = "cboTreino";
            cboTreino.Size = new Size(384, 49);
            cboTreino.StartIndex = 0;
            cboTreino.TabIndex = 17;
            // 
            // cboExercicio
            // 
            cboExercicio.AutoResize = false;
            cboExercicio.BackColor = Color.FromArgb(255, 255, 255);
            cboExercicio.Depth = 0;
            cboExercicio.DrawMode = DrawMode.OwnerDrawVariable;
            cboExercicio.DropDownHeight = 174;
            cboExercicio.DropDownStyle = ComboBoxStyle.DropDownList;
            cboExercicio.DropDownWidth = 121;
            cboExercicio.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboExercicio.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboExercicio.FormattingEnabled = true;
            cboExercicio.Hint = "Exercicio";
            cboExercicio.IntegralHeight = false;
            cboExercicio.ItemHeight = 43;
            cboExercicio.Location = new Point(395, 61);
            cboExercicio.MaxDropDownItems = 4;
            cboExercicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboExercicio.Name = "cboExercicio";
            cboExercicio.Size = new Size(384, 49);
            cboExercicio.StartIndex = 0;
            cboExercicio.TabIndex = 18;
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(6, 7);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(384, 48);
            txtId.TabIndex = 19;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtSeries
            // 
            txtSeries.AnimateReadOnly = false;
            txtSeries.AutoCompleteMode = AutoCompleteMode.None;
            txtSeries.AutoCompleteSource = AutoCompleteSource.None;
            txtSeries.BackgroundImageLayout = ImageLayout.None;
            txtSeries.CharacterCasing = CharacterCasing.Normal;
            txtSeries.Depth = 0;
            txtSeries.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSeries.HideSelection = true;
            txtSeries.Hint = "Series";
            txtSeries.LeadingIcon = null;
            txtSeries.Location = new Point(6, 93);
            txtSeries.MaxLength = 32767;
            txtSeries.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSeries.Name = "txtSeries";
            txtSeries.PasswordChar = '\0';
            txtSeries.PrefixSuffixText = null;
            txtSeries.ReadOnly = false;
            txtSeries.RightToLeft = RightToLeft.No;
            txtSeries.SelectedText = "";
            txtSeries.SelectionLength = 0;
            txtSeries.SelectionStart = 0;
            txtSeries.ShortcutsEnabled = true;
            txtSeries.Size = new Size(384, 48);
            txtSeries.TabIndex = 20;
            txtSeries.TabStop = false;
            txtSeries.TextAlign = HorizontalAlignment.Left;
            txtSeries.TrailingIcon = null;
            txtSeries.UseSystemPasswordChar = false;
            // 
            // txtRepeticoes
            // 
            txtRepeticoes.AnimateReadOnly = false;
            txtRepeticoes.AutoCompleteMode = AutoCompleteMode.None;
            txtRepeticoes.AutoCompleteSource = AutoCompleteSource.None;
            txtRepeticoes.BackgroundImageLayout = ImageLayout.None;
            txtRepeticoes.CharacterCasing = CharacterCasing.Normal;
            txtRepeticoes.Depth = 0;
            txtRepeticoes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRepeticoes.HideSelection = true;
            txtRepeticoes.Hint = "Repetições";
            txtRepeticoes.LeadingIcon = null;
            txtRepeticoes.Location = new Point(6, 173);
            txtRepeticoes.MaxLength = 32767;
            txtRepeticoes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtRepeticoes.Name = "txtRepeticoes";
            txtRepeticoes.PasswordChar = '\0';
            txtRepeticoes.PrefixSuffixText = null;
            txtRepeticoes.ReadOnly = false;
            txtRepeticoes.RightToLeft = RightToLeft.No;
            txtRepeticoes.SelectedText = "";
            txtRepeticoes.SelectionLength = 0;
            txtRepeticoes.SelectionStart = 0;
            txtRepeticoes.ShortcutsEnabled = true;
            txtRepeticoes.Size = new Size(384, 48);
            txtRepeticoes.TabIndex = 21;
            txtRepeticoes.TabStop = false;
            txtRepeticoes.TextAlign = HorizontalAlignment.Left;
            txtRepeticoes.TrailingIcon = null;
            txtRepeticoes.UseSystemPasswordChar = false;
            // 
            // txtCarga
            // 
            txtCarga.AnimateReadOnly = false;
            txtCarga.AutoCompleteMode = AutoCompleteMode.None;
            txtCarga.AutoCompleteSource = AutoCompleteSource.None;
            txtCarga.BackgroundImageLayout = ImageLayout.None;
            txtCarga.CharacterCasing = CharacterCasing.Normal;
            txtCarga.Depth = 0;
            txtCarga.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCarga.HideSelection = true;
            txtCarga.Hint = "Carga";
            txtCarga.LeadingIcon = null;
            txtCarga.Location = new Point(6, 247);
            txtCarga.MaxLength = 32767;
            txtCarga.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCarga.Name = "txtCarga";
            txtCarga.PasswordChar = '\0';
            txtCarga.PrefixSuffixText = null;
            txtCarga.ReadOnly = false;
            txtCarga.RightToLeft = RightToLeft.No;
            txtCarga.SelectedText = "";
            txtCarga.SelectionLength = 0;
            txtCarga.SelectionStart = 0;
            txtCarga.ShortcutsEnabled = true;
            txtCarga.Size = new Size(384, 48);
            txtCarga.TabIndex = 22;
            txtCarga.TabStop = false;
            txtCarga.TextAlign = HorizontalAlignment.Left;
            txtCarga.TrailingIcon = null;
            txtCarga.UseSystemPasswordChar = false;
            // 
            // dgvItensTemporarios
            // 
            dgvItensTemporarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensTemporarios.Location = new Point(396, 116);
            dgvItensTemporarios.Name = "dgvItensTemporarios";
            dgvItensTemporarios.Size = new Size(383, 179);
            dgvItensTemporarios.TabIndex = 23;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionar.Depth = 0;
            btnAdicionar.HighEmphasis = true;
            btnAdicionar.Icon = null;
            btnAdicionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdicionar.Location = new Point(6, 304);
            btnAdicionar.Margin = new Padding(4, 6, 4, 6);
            btnAdicionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.NoAccentTextColor = Color.Empty;
            btnAdicionar.Size = new Size(158, 36);
            btnAdicionar.TabIndex = 24;
            btnAdicionar.Text = "Adicionar";
            btnAdicionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionar.UseAccentColor = false;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
            // 
            // CadastroItemTreino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroItemTreino";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroItemTreino";
            TabControlCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensTemporarios).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboExercicio;
        private ReaLTaiizor.Controls.MaterialComboBox cboTreino;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtSeries;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtCarga;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtRepeticoes;
        private DataGridView dgvItensTemporarios;
        private ReaLTaiizor.Controls.MaterialButton btnAdicionar;
    }
}