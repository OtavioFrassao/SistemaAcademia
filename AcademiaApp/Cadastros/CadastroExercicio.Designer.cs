namespace AcademiaApp.Cadastros
{
    partial class CadastroExercicio
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
            txtGrupoMuscular = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            TabControlCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(809, 385);
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(176, 196);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(72, 196);
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(633, 312);
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(561, 312);
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(712, 312);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtGrupoMuscular);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(801, 357);
            tabPageCadastro.Controls.SetChildIndex(buttonCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtGrupoMuscular, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
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
            txtId.Location = new Point(36, 31);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = false;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(216, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtGrupoMuscular
            // 
            txtGrupoMuscular.AnimateReadOnly = false;
            txtGrupoMuscular.AutoCompleteMode = AutoCompleteMode.None;
            txtGrupoMuscular.AutoCompleteSource = AutoCompleteSource.None;
            txtGrupoMuscular.BackgroundImageLayout = ImageLayout.None;
            txtGrupoMuscular.CharacterCasing = CharacterCasing.Normal;
            txtGrupoMuscular.Depth = 0;
            txtGrupoMuscular.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtGrupoMuscular.HideSelection = true;
            txtGrupoMuscular.Hint = "GrupoMuscular";
            txtGrupoMuscular.LeadingIcon = null;
            txtGrupoMuscular.Location = new Point(36, 139);
            txtGrupoMuscular.MaxLength = 32767;
            txtGrupoMuscular.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtGrupoMuscular.Name = "txtGrupoMuscular";
            txtGrupoMuscular.PasswordChar = '\0';
            txtGrupoMuscular.PrefixSuffixText = null;
            txtGrupoMuscular.ReadOnly = false;
            txtGrupoMuscular.RightToLeft = RightToLeft.No;
            txtGrupoMuscular.SelectedText = "";
            txtGrupoMuscular.SelectionLength = 0;
            txtGrupoMuscular.SelectionStart = 0;
            txtGrupoMuscular.ShortcutsEnabled = true;
            txtGrupoMuscular.Size = new Size(216, 48);
            txtGrupoMuscular.TabIndex = 3;
            txtGrupoMuscular.TabStop = false;
            txtGrupoMuscular.TextAlign = HorizontalAlignment.Left;
            txtGrupoMuscular.TrailingIcon = null;
            txtGrupoMuscular.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(36, 85);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(216, 48);
            txtNome.TabIndex = 4;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // CadastroExercicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 452);
            Location = new Point(0, 0);
            Name = "CadastroExercicio";
            Text = "CadastraExercicio";
            TabControlCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtGrupoMuscular;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
    }
}