namespace AcademiaApp.Cadastros
{
    partial class CadastroTreino
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
            cboAluno = new ReaLTaiizor.Controls.MaterialComboBox();
            txtDataFim = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDataInicio = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtDescricao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNomeTreino = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TabControlCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(794, 383);
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(703, 313);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(599, 313);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboAluno);
            tabPageCadastro.Controls.Add(txtDataFim);
            tabPageCadastro.Controls.Add(txtDataInicio);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtNomeTreino);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(786, 355);
            tabPageCadastro.Controls.SetChildIndex(buttonCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNomeTreino, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataInicio, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataFim, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAluno, 0);
            // 
            // cboAluno
            // 
            cboAluno.AutoResize = false;
            cboAluno.BackColor = Color.FromArgb(255, 255, 255);
            cboAluno.Depth = 0;
            cboAluno.DrawMode = DrawMode.OwnerDrawVariable;
            cboAluno.DropDownHeight = 174;
            cboAluno.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAluno.DropDownWidth = 121;
            cboAluno.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboAluno.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboAluno.FormattingEnabled = true;
            cboAluno.Hint = "Aluno";
            cboAluno.IntegralHeight = false;
            cboAluno.ItemHeight = 43;
            cboAluno.Location = new Point(6, 168);
            cboAluno.MaxDropDownItems = 4;
            cboAluno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAluno.Name = "cboAluno";
            cboAluno.Size = new Size(384, 49);
            cboAluno.StartIndex = 0;
            cboAluno.TabIndex = 16;
            // 
            // txtDataFim
            // 
            txtDataFim.AllowPromptAsInput = true;
            txtDataFim.AnimateReadOnly = false;
            txtDataFim.AsciiOnly = false;
            txtDataFim.BackgroundImageLayout = ImageLayout.None;
            txtDataFim.BeepOnError = false;
            txtDataFim.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataFim.Depth = 0;
            txtDataFim.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataFim.HidePromptOnLeave = false;
            txtDataFim.HideSelection = true;
            txtDataFim.Hint = "Data Fim";
            txtDataFim.InsertKeyMode = InsertKeyMode.Default;
            txtDataFim.LeadingIcon = null;
            txtDataFim.Location = new Point(447, 60);
            txtDataFim.Mask = "00/00/0000";
            txtDataFim.MaxLength = 32767;
            txtDataFim.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataFim.Name = "txtDataFim";
            txtDataFim.PasswordChar = '\0';
            txtDataFim.PrefixSuffixText = null;
            txtDataFim.PromptChar = '_';
            txtDataFim.ReadOnly = false;
            txtDataFim.RejectInputOnFirstFailure = false;
            txtDataFim.ResetOnPrompt = true;
            txtDataFim.ResetOnSpace = true;
            txtDataFim.RightToLeft = RightToLeft.No;
            txtDataFim.SelectedText = "";
            txtDataFim.SelectionLength = 0;
            txtDataFim.SelectionStart = 0;
            txtDataFim.ShortcutsEnabled = true;
            txtDataFim.Size = new Size(208, 48);
            txtDataFim.SkipLiterals = true;
            txtDataFim.TabIndex = 15;
            txtDataFim.TabStop = false;
            txtDataFim.Text = "  /  /";
            txtDataFim.TextAlign = HorizontalAlignment.Left;
            txtDataFim.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataFim.TrailingIcon = null;
            txtDataFim.UseSystemPasswordChar = false;
            txtDataFim.ValidatingType = null;
            // 
            // txtDataInicio
            // 
            txtDataInicio.AllowPromptAsInput = true;
            txtDataInicio.AnimateReadOnly = false;
            txtDataInicio.AsciiOnly = false;
            txtDataInicio.BackgroundImageLayout = ImageLayout.None;
            txtDataInicio.BeepOnError = false;
            txtDataInicio.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataInicio.Depth = 0;
            txtDataInicio.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataInicio.HidePromptOnLeave = false;
            txtDataInicio.HideSelection = true;
            txtDataInicio.Hint = "Data Inicio";
            txtDataInicio.InsertKeyMode = InsertKeyMode.Default;
            txtDataInicio.LeadingIcon = null;
            txtDataInicio.Location = new Point(447, 6);
            txtDataInicio.Mask = "00/00/0000";
            txtDataInicio.MaxLength = 32767;
            txtDataInicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataInicio.Name = "txtDataInicio";
            txtDataInicio.PasswordChar = '\0';
            txtDataInicio.PrefixSuffixText = null;
            txtDataInicio.PromptChar = '_';
            txtDataInicio.ReadOnly = false;
            txtDataInicio.RejectInputOnFirstFailure = false;
            txtDataInicio.ResetOnPrompt = true;
            txtDataInicio.ResetOnSpace = true;
            txtDataInicio.RightToLeft = RightToLeft.No;
            txtDataInicio.SelectedText = "";
            txtDataInicio.SelectionLength = 0;
            txtDataInicio.SelectionStart = 0;
            txtDataInicio.ShortcutsEnabled = true;
            txtDataInicio.Size = new Size(208, 48);
            txtDataInicio.SkipLiterals = true;
            txtDataInicio.TabIndex = 14;
            txtDataInicio.TabStop = false;
            txtDataInicio.Text = "  /  /";
            txtDataInicio.TextAlign = HorizontalAlignment.Left;
            txtDataInicio.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataInicio.TrailingIcon = null;
            txtDataInicio.UseSystemPasswordChar = false;
            txtDataInicio.ValidatingType = null;
            // 
            // txtDescricao
            // 
            txtDescricao.AnimateReadOnly = false;
            txtDescricao.AutoCompleteMode = AutoCompleteMode.None;
            txtDescricao.AutoCompleteSource = AutoCompleteSource.None;
            txtDescricao.BackgroundImageLayout = ImageLayout.None;
            txtDescricao.CharacterCasing = CharacterCasing.Normal;
            txtDescricao.Depth = 0;
            txtDescricao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDescricao.HideSelection = true;
            txtDescricao.Hint = "Descrição";
            txtDescricao.LeadingIcon = null;
            txtDescricao.Location = new Point(6, 114);
            txtDescricao.MaxLength = 32767;
            txtDescricao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.PasswordChar = '\0';
            txtDescricao.PrefixSuffixText = null;
            txtDescricao.ReadOnly = false;
            txtDescricao.RightToLeft = RightToLeft.No;
            txtDescricao.SelectedText = "";
            txtDescricao.SelectionLength = 0;
            txtDescricao.SelectionStart = 0;
            txtDescricao.ShortcutsEnabled = true;
            txtDescricao.Size = new Size(384, 48);
            txtDescricao.TabIndex = 13;
            txtDescricao.TabStop = false;
            txtDescricao.TextAlign = HorizontalAlignment.Left;
            txtDescricao.TrailingIcon = null;
            txtDescricao.UseSystemPasswordChar = false;
            // 
            // txtNomeTreino
            // 
            txtNomeTreino.AnimateReadOnly = false;
            txtNomeTreino.AutoCompleteMode = AutoCompleteMode.None;
            txtNomeTreino.AutoCompleteSource = AutoCompleteSource.None;
            txtNomeTreino.BackgroundImageLayout = ImageLayout.None;
            txtNomeTreino.CharacterCasing = CharacterCasing.Normal;
            txtNomeTreino.Depth = 0;
            txtNomeTreino.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNomeTreino.HideSelection = true;
            txtNomeTreino.Hint = "Nome Treino";
            txtNomeTreino.LeadingIcon = null;
            txtNomeTreino.Location = new Point(6, 60);
            txtNomeTreino.MaxLength = 32767;
            txtNomeTreino.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNomeTreino.Name = "txtNomeTreino";
            txtNomeTreino.PasswordChar = '\0';
            txtNomeTreino.PrefixSuffixText = null;
            txtNomeTreino.ReadOnly = false;
            txtNomeTreino.RightToLeft = RightToLeft.No;
            txtNomeTreino.SelectedText = "";
            txtNomeTreino.SelectionLength = 0;
            txtNomeTreino.SelectionStart = 0;
            txtNomeTreino.ShortcutsEnabled = true;
            txtNomeTreino.Size = new Size(384, 48);
            txtNomeTreino.TabIndex = 12;
            txtNomeTreino.TabStop = false;
            txtNomeTreino.TextAlign = HorizontalAlignment.Left;
            txtNomeTreino.TrailingIcon = null;
            txtNomeTreino.UseSystemPasswordChar = false;
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
            txtId.Location = new Point(6, 6);
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
            txtId.TabIndex = 11;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // CadastroTreino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroTreino";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroTreino";
            TabControlCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboAluno;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataFim;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataInicio;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeTreino;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
    }
}