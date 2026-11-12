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
            grpExercicios = new GroupBox();
            btnEditarItem = new ReaLTaiizor.Controls.MaterialButton();
            btnRemover = new ReaLTaiizor.Controls.MaterialButton();
            dgvItensTreino = new DataGridView();
            btnAdicionar = new ReaLTaiizor.Controls.MaterialButton();
            txtCarga = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtRepeticoes = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtSeries = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboExercicio = new ReaLTaiizor.Controls.MaterialComboBox();
            dgvExerciciosConsulta = new DataGridView();
            TabControlCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            grpExercicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensTreino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvExerciciosConsulta).BeginInit();
            SuspendLayout();
            // 
            // TabControlCadastro
            // 
            TabControlCadastro.Size = new Size(1104, 708);
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(dgvExerciciosConsulta);
            tabPageConsulta.Controls.SetChildIndex(dgvExerciciosConsulta, 0);
            tabPageConsulta.Controls.SetChildIndex(buttonNovo, 0);
            tabPageConsulta.Controls.SetChildIndex(buttonEditar, 0);
            tabPageConsulta.Controls.SetChildIndex(buttonExcluir, 0);
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(1005, 629);
            // 
            // buttonCancelar
            // 
            buttonCancelar.Location = new Point(901, 629);
            // 
            // buttonEditar
            // 
            buttonEditar.Location = new Point(608, 310);
            // 
            // buttonNovo
            // 
            buttonNovo.Location = new Point(536, 310);
            // 
            // buttonExcluir
            // 
            buttonExcluir.Location = new Point(687, 310);
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(cboAluno);
            tabPageCadastro.Controls.Add(txtDataFim);
            tabPageCadastro.Controls.Add(txtDataInicio);
            tabPageCadastro.Controls.Add(txtDescricao);
            tabPageCadastro.Controls.Add(txtNomeTreino);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(grpExercicios);
            tabPageCadastro.Size = new Size(1096, 680);
            tabPageCadastro.Controls.SetChildIndex(grpExercicios, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNomeTreino, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDescricao, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataInicio, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataFim, 0);
            tabPageCadastro.Controls.SetChildIndex(cboAluno, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(buttonSalvar, 0);
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
            cboAluno.Location = new Point(29, 61);
            cboAluno.MaxDropDownItems = 4;
            cboAluno.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboAluno.Name = "cboAluno";
            cboAluno.Size = new Size(509, 49);
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
            txtDataFim.Location = new Point(573, 134);
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
            txtDataFim.Size = new Size(492, 48);
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
            txtDataInicio.Location = new Point(29, 134);
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
            txtDataInicio.Size = new Size(509, 48);
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
            txtDescricao.Location = new Point(29, 200);
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
            txtDescricao.Size = new Size(1036, 48);
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
            txtNomeTreino.Location = new Point(573, 61);
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
            txtNomeTreino.Size = new Size(492, 48);
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
            txtId.Location = new Point(29, 6);
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
            // grpExercicios
            // 
            grpExercicios.Controls.Add(btnEditarItem);
            grpExercicios.Controls.Add(btnRemover);
            grpExercicios.Controls.Add(dgvItensTreino);
            grpExercicios.Controls.Add(btnAdicionar);
            grpExercicios.Controls.Add(txtCarga);
            grpExercicios.Controls.Add(txtRepeticoes);
            grpExercicios.Controls.Add(txtSeries);
            grpExercicios.Controls.Add(cboExercicio);
            grpExercicios.Location = new Point(29, 265);
            grpExercicios.Name = "grpExercicios";
            grpExercicios.Size = new Size(1036, 349);
            grpExercicios.TabIndex = 17;
            grpExercicios.TabStop = false;
            grpExercicios.Text = "Exercícios do Treino";
            // 
            // btnEditarItem
            // 
            btnEditarItem.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditarItem.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditarItem.Depth = 0;
            btnEditarItem.HighEmphasis = true;
            btnEditarItem.Icon = null;
            btnEditarItem.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditarItem.Location = new Point(224, 78);
            btnEditarItem.Margin = new Padding(4, 6, 4, 6);
            btnEditarItem.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditarItem.Name = "btnEditarItem";
            btnEditarItem.NoAccentTextColor = Color.Empty;
            btnEditarItem.Size = new Size(173, 36);
            btnEditarItem.TabIndex = 28;
            btnEditarItem.Text = "EDITAR SELECIONADO";
            btnEditarItem.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditarItem.UseAccentColor = false;
            btnEditarItem.UseVisualStyleBackColor = true;
            btnEditarItem.Click += btnEditarItem_Click;
            // 
            // btnRemover
            // 
            btnRemover.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnRemover.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnRemover.Depth = 0;
            btnRemover.HighEmphasis = true;
            btnRemover.Icon = null;
            btnRemover.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnRemover.Location = new Point(405, 78);
            btnRemover.Margin = new Padding(4, 6, 4, 6);
            btnRemover.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnRemover.Name = "btnRemover";
            btnRemover.NoAccentTextColor = Color.Empty;
            btnRemover.Size = new Size(165, 36);
            btnRemover.TabIndex = 27;
            btnRemover.Text = "- REMOVE EXERCICIO";
            btnRemover.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnRemover.UseAccentColor = false;
            btnRemover.UseVisualStyleBackColor = true;
            btnRemover.Click += btnRemover_Click;
            // 
            // dgvItensTreino
            // 
            dgvItensTreino.AllowUserToAddRows = false;
            dgvItensTreino.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvItensTreino.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvItensTreino.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvItensTreino.Location = new Point(29, 124);
            dgvItensTreino.Name = "dgvItensTreino";
            dgvItensTreino.ReadOnly = true;
            dgvItensTreino.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvItensTreino.Size = new Size(977, 219);
            dgvItensTreino.TabIndex = 26;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionar.Depth = 0;
            btnAdicionar.HighEmphasis = true;
            btnAdicionar.Icon = null;
            btnAdicionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdicionar.Location = new Point(29, 79);
            btnAdicionar.Margin = new Padding(4, 6, 4, 6);
            btnAdicionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.NoAccentTextColor = Color.Empty;
            btnAdicionar.Size = new Size(187, 36);
            btnAdicionar.TabIndex = 25;
            btnAdicionar.Text = "+ Adicionar Exercicio";
            btnAdicionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionar.UseAccentColor = false;
            btnAdicionar.UseVisualStyleBackColor = true;
            btnAdicionar.Click += btnAdicionar_Click;
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
            txtCarga.Location = new Point(857, 22);
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
            txtCarga.Size = new Size(149, 48);
            txtCarga.TabIndex = 23;
            txtCarga.TabStop = false;
            txtCarga.TextAlign = HorizontalAlignment.Left;
            txtCarga.TrailingIcon = null;
            txtCarga.UseSystemPasswordChar = false;
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
            txtRepeticoes.Location = new Point(655, 22);
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
            txtRepeticoes.Size = new Size(176, 48);
            txtRepeticoes.TabIndex = 22;
            txtRepeticoes.TabStop = false;
            txtRepeticoes.TextAlign = HorizontalAlignment.Left;
            txtRepeticoes.TrailingIcon = null;
            txtRepeticoes.UseSystemPasswordChar = false;
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
            txtSeries.Location = new Point(459, 21);
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
            txtSeries.Size = new Size(175, 48);
            txtSeries.TabIndex = 21;
            txtSeries.TabStop = false;
            txtSeries.TextAlign = HorizontalAlignment.Left;
            txtSeries.TrailingIcon = null;
            txtSeries.UseSystemPasswordChar = false;
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
            cboExercicio.Location = new Point(29, 21);
            cboExercicio.MaxDropDownItems = 4;
            cboExercicio.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboExercicio.Name = "cboExercicio";
            cboExercicio.Size = new Size(402, 49);
            cboExercicio.StartIndex = 0;
            cboExercicio.TabIndex = 19;
            // 
            // dgvExerciciosConsulta
            // 
            dgvExerciciosConsulta.AllowUserToAddRows = false;
            dgvExerciciosConsulta.AllowUserToDeleteRows = false;
            dgvExerciciosConsulta.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvExerciciosConsulta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvExerciciosConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvExerciciosConsulta.Location = new Point(2, 280);
            dgvExerciciosConsulta.Name = "dgvExerciciosConsulta";
            dgvExerciciosConsulta.ReadOnly = true;
            dgvExerciciosConsulta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvExerciciosConsulta.Size = new Size(6111, 329);
            dgvExerciciosConsulta.TabIndex = 4;
            // 
            // CadastroTreino
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 775);
            Location = new Point(0, 0);
            Name = "CadastroTreino";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CadastroTreino";
            TabControlCadastro.ResumeLayout(false);
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            grpExercicios.ResumeLayout(false);
            grpExercicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvItensTreino).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvExerciciosConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboAluno;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataFim;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataInicio;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtDescricao;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtNomeTreino;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private GroupBox grpExercicios;
        private ReaLTaiizor.Controls.MaterialComboBox cboExercicio;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtSeries;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtRepeticoes;
        protected ReaLTaiizor.Controls.MaterialTextBoxEdit txtCarga;
        private ReaLTaiizor.Controls.MaterialButton btnAdicionar;
        private DataGridView dgvItensTreino;
        private ReaLTaiizor.Controls.MaterialButton btnRemover;
        private ReaLTaiizor.Controls.MaterialButton btnEditarItem;
        private DataGridView dgvExerciciosConsulta;
    }
}