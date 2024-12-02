using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exemplo1_35347
{
    public partial class frmCadastrarPessoa : Form
    {
        #region formLoad
        public frmCadastrarPessoa()
        {
            InitializeComponent();
        }
        #endregion

        #region btnAdd
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();

            bool teste = banco.CadastrarPessoa(txtNome.Text, txtCPF.Text, txtTelefone.Text);

            if (!teste)
                MessageBox.Show("Informe os valores corretamente");
            else
                Close();

        }
        #endregion

        #region btnCancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        { 
            Close();
        }
        #endregion

        #region Verificar
        private void verificar()
        {
            if (txtNome.Text.Trim() != "" && txtCPF.Text.Trim() != "" && txtTelefone.Text.Trim() != "")
            {
                btnAdicionar.Enabled = true;
            }
            else
                btnAdicionar.Enabled = false;
        }
        #endregion

        #region txts
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            verificar();
        }
        #endregion
    }
}
