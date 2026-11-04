using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AcademiaApp.Base
{
    public partial class CadastroBase : MaterialForm
    {
        #region Declarações
        protected bool IsEditMode = false;
        #endregion
        #region Construtor
        public CadastroBase()
        {
            InitializeComponent();
        }
        #endregion

        #region Eventos de Tela

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Se a tela for filha de um Form MDI Principal, calcula o centro
            if (MdiParent != null)
            {
                this.Location = new System.Drawing.Point(
                    (MdiParent.ClientSize.Width - this.Width) / 2,
                    (MdiParent.ClientSize.Height - this.Height) / 2
                );
            }
            else
            {
                this.StartPosition = FormStartPosition.CenterScreen;
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Deseja realmente cancelar?", "Cancelar",
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                LimpaCampos();
                TabControlCadastro.SelectedIndex = 1;
            }
        }

        private void buttonSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void buttonNovo_Click(object sender, EventArgs e)
        {
            Novo();
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            Editar();
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                var result = MessageBox.Show("Deseja realmente excluir o registro?", "Excluir",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(dataGridViewConsulta.SelectedRows[0].Cells[0].Value);
                    Deletar(id);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro para excluir!", "Excluir",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void TabPageConsulta_Enter(object sender, EventArgs e)
        {
            CarregaGrid();
        }
        #endregion

        #region Métodos Virtuais
        protected virtual void CarregaGrid()
        {
            throw new NotImplementedException();
        }

        protected virtual void Salvar()
        {
            throw new NotImplementedException();
        }

        protected virtual void Novo()
        {
            LimpaCampos();
            TabControlCadastro.SelectedIndex = 0;
            TabControlCadastro.Focus();
        }

        protected virtual void Editar()
        {
            if (dataGridViewConsulta.SelectedRows.Count > 0)
            {
                var row = dataGridViewConsulta.SelectedRows[0];
                CarregarRegistro(row);
                IsEditMode = true;
                TabControlCadastro.SelectedIndex = 0;
                TabControlCadastro.Focus();
            }
            else
            {
                MessageBox.Show("Selecione um registro para editar!", "Editar",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        protected virtual void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        protected virtual void CarregarRegistro(DataGridViewRow row)
        {
            throw new NotImplementedException();
        }

        private void LimpaCampos()
        {
            IsEditMode = false;
            foreach (var control in tabPageCadastro.Controls)
            {
                if (control is MaterialTextBoxEdit textBox)
                    textBox.Clear();
                if (control is MaterialMaskedTextBox maskedBox)
                    maskedBox.Clear();
            }
        }
        #endregion
    }
}


