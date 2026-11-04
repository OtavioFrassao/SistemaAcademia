namespace AcademiaApp.Cadastros
{
    partial class CadastroAvaliacaoFisica
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
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboAluno = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPeso = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtAltura = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtPercentualGordura = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtObservacao = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
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
            buttonSalvar.Location = new Point(703, 280);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(599, 280);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtObservacao);
            tabPageCadastro.Controls.Add(txtPercentualGordura);
            tabPageCadastro.Controls.Add(txtAltura);
            tabPageCadastro.Controls.Add(txtPeso);
            tabPageCadastro.Controls.Add(cboAluno);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(786, 355);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAluno, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPeso, 0);
            tabPageCadastro.Controls.SetChildIndex(txtAltura, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtPercentualGordura, 0);
            tabPageCadastro.Controls.SetChildIndex(txtObservacao, 0);
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
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
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
            cboAluno.Location = new Point(6, 60);
            cboAluno.MaxDropDownItems = 4;
            cboAluno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAluno.Name = "cboAluno";
            cboAluno.Size = new Size(384, 49);
            cboAluno.StartIndex = 0;
            cboAluno.TabIndex = 5;
            // 
            // txtPeso
            // 
            txtPeso.AnimateReadOnly = false;
            txtPeso.AutoCompleteMode = AutoCompleteMode.None;
            txtPeso.AutoCompleteSource = AutoCompleteSource.None;
            txtPeso.BackgroundImageLayout = ImageLayout.None;
            txtPeso.CharacterCasing = CharacterCasing.Normal;
            txtPeso.Depth = 0;
            txtPeso.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPeso.HideSelection = true;
            txtPeso.Hint = "Peso";
            txtPeso.LeadingIcon = null;
            txtPeso.Location = new Point(6, 115);
            txtPeso.MaxLength = 32767;
            txtPeso.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPeso.Name = "txtPeso";
            txtPeso.PasswordChar = '\0';
            txtPeso.PrefixSuffixText = null;
            txtPeso.ReadOnly = false;
            txtPeso.RightToLeft = RightToLeft.No;
            txtPeso.SelectedText = "";
            txtPeso.SelectionLength = 0;
            txtPeso.SelectionStart = 0;
            txtPeso.ShortcutsEnabled = true;
            txtPeso.Size = new Size(384, 48);
            txtPeso.TabIndex = 6;
            txtPeso.TabStop = false;
            txtPeso.TextAlign = HorizontalAlignment.Left;
            txtPeso.TrailingIcon = null;
            txtPeso.UseSystemPasswordChar = false;
            // 
            // txtAltura
            // 
            txtAltura.AnimateReadOnly = false;
            txtAltura.AutoCompleteMode = AutoCompleteMode.None;
            txtAltura.AutoCompleteSource = AutoCompleteSource.None;
            txtAltura.BackgroundImageLayout = ImageLayout.None;
            txtAltura.CharacterCasing = CharacterCasing.Normal;
            txtAltura.Depth = 0;
            txtAltura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAltura.HideSelection = true;
            txtAltura.Hint = "Altura";
            txtAltura.LeadingIcon = null;
            txtAltura.Location = new Point(6, 169);
            txtAltura.MaxLength = 32767;
            txtAltura.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAltura.Name = "txtAltura";
            txtAltura.PasswordChar = '\0';
            txtAltura.PrefixSuffixText = null;
            txtAltura.ReadOnly = false;
            txtAltura.RightToLeft = RightToLeft.No;
            txtAltura.SelectedText = "";
            txtAltura.SelectionLength = 0;
            txtAltura.SelectionStart = 0;
            txtAltura.ShortcutsEnabled = true;
            txtAltura.Size = new Size(384, 48);
            txtAltura.TabIndex = 7;
            txtAltura.TabStop = false;
            txtAltura.TextAlign = HorizontalAlignment.Left;
            txtAltura.TrailingIcon = null;
            txtAltura.UseSystemPasswordChar = false;
            // 
            // txtPercentualGordura
            // 
            txtPercentualGordura.AnimateReadOnly = false;
            txtPercentualGordura.AutoCompleteMode = AutoCompleteMode.None;
            txtPercentualGordura.AutoCompleteSource = AutoCompleteSource.None;
            txtPercentualGordura.BackgroundImageLayout = ImageLayout.None;
            txtPercentualGordura.CharacterCasing = CharacterCasing.Normal;
            txtPercentualGordura.Depth = 0;
            txtPercentualGordura.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPercentualGordura.HideSelection = true;
            txtPercentualGordura.Hint = "Percentual De Gordura";
            txtPercentualGordura.LeadingIcon = null;
            txtPercentualGordura.Location = new Point(6, 223);
            txtPercentualGordura.MaxLength = 32767;
            txtPercentualGordura.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPercentualGordura.Name = "txtPercentualGordura";
            txtPercentualGordura.PasswordChar = '\0';
            txtPercentualGordura.PrefixSuffixText = null;
            txtPercentualGordura.ReadOnly = false;
            txtPercentualGordura.RightToLeft = RightToLeft.No;
            txtPercentualGordura.SelectedText = "";
            txtPercentualGordura.SelectionLength = 0;
            txtPercentualGordura.SelectionStart = 0;
            txtPercentualGordura.ShortcutsEnabled = true;
            txtPercentualGordura.Size = new Size(384, 48);
            txtPercentualGordura.TabIndex = 8;
            txtPercentualGordura.TabStop = false;
            txtPercentualGordura.TextAlign = HorizontalAlignment.Left;
            txtPercentualGordura.TrailingIcon = null;
            txtPercentualGordura.UseSystemPasswordChar = false;
            // 
            // txtObservacao
            // 
            txtObservacao.AnimateReadOnly = false;
            txtObservacao.AutoCompleteMode = AutoCompleteMode.None;
            txtObservacao.AutoCompleteSource = AutoCompleteSource.None;
            txtObservacao.BackgroundImageLayout = ImageLayout.None;
            txtObservacao.CharacterCasing = CharacterCasing.Normal;
            txtObservacao.Depth = 0;
            txtObservacao.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtObservacao.HideSelection = true;
            txtObservacao.Hint = "Observação";
            txtObservacao.LeadingIcon = null;
            txtObservacao.Location = new Point(414, 3);
            txtObservacao.MaxLength = 32767;
            txtObservacao.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtObservacao.Name = "txtObservacao";
            txtObservacao.PasswordChar = '\0';
            txtObservacao.PrefixSuffixText = null;
            txtObservacao.ReadOnly = false;
            txtObservacao.RightToLeft = RightToLeft.No;
            txtObservacao.SelectedText = "";
            txtObservacao.SelectionLength = 0;
            txtObservacao.SelectionStart = 0;
            txtObservacao.ShortcutsEnabled = true;
            txtObservacao.Size = new Size(366, 48);
            txtObservacao.TabIndex = 9;
            txtObservacao.TabStop = false;
            txtObservacao.TextAlign = HorizontalAlignment.Left;
            txtObservacao.TrailingIcon = null;
            txtObservacao.UseSystemPasswordChar = false;
            // 
            // CadastroAvaliacaoFisica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Location = new Point(0, 0);
            Name = "CadastroAvaliacaoFisica";
            Text = "CadastroAvaliacaoFisica";
            TabControlCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtPercentualGordura;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtAltura;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtPeso;
        private ReaLTaiizor.Controls.MaterialComboBox cboAluno;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtObservacao;
    }
}