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
            List<string> listaCPFs = banco.pegarCPFs();

            string CPF = txtCPF.Text;
            string Nome = txtNome.Text;
            string Telefone = txtTelefone.Text;

            foreach (var cpf in listaCPFs)
            {
                if (cpf == CPF)
                {
                    lblResp.Text = "CPF já cadastrado";
                    txtCPF.Text = "";
                    txtCPF.Focus();
                    break;
                }
            }

            banco.adicionarPessoa(Nome, CPF, Telefone);

            frmListarPessoas listarPessoas = new frmListarPessoas();
            listarPessoas.Show();
            this.Visible = false;

        }
        #endregion

        #region btnCancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region FormClosing
        private void frmCadastrarPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmListarPessoas listarPessoas = new frmListarPessoas();
            listarPessoas.Show();
            this.Visible = false;
        }
        #endregion
    }
}
