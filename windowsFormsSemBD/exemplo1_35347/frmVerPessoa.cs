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
    public partial class frmVerPessoa : Form
    {
        string Indice = "";

        #region Incializar
        public frmVerPessoa(string indice)
        {
            Indice = indice;
            InitializeComponent();
        }
        #endregion

        #region formLoad
        private void frmVerPessoa_Load(object sender, EventArgs e)
        {
            Banco banco = new Banco();
            string[] pessoa = new string[3];
            pessoa = banco.pessoaEspecifica(Indice);

            string Nome = pessoa[0];
            string CPF = pessoa[1];
            string Telefone = pessoa[2];

            txtNome.Text = Nome;
            txtCPF.Text = CPF;
            txtTelefone.Text = Telefone;

        }
        #endregion

        #region btnCancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region btnEditar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();

            string[] pessoa = new string[3];
            pessoa = banco.pessoaEspecifica(Indice);

            List<string> listaCPFs = banco.pegarCPFs();

            string CPF = pessoa[1].ToString();
            string Cpf = txtCPF.Text;
            string Nome = txtNome.Text;
            string Telefone = txtTelefone.Text;

            foreach (var cpf in listaCPFs)
            {
                if (cpf == Cpf && cpf != CPF)
                {
                    lblResp.Text = "CPF já cadastrado";
                    txtCPF.Text = "";
                    txtCPF.Focus();
                    return;
                }
            }

            lblResp.Text = banco.editarPessoa(Nome, Cpf, Telefone, CPF);

            Close();
        }
        #endregion

        #region FormClosing
        private void frmVerPessoa_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmListarPessoas listarPessoas = new frmListarPessoas();
            listarPessoas.Show();
            this.Visible = false;
        }
        #endregion

        #region btnExcluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Banco banco = new Banco();

            string[] pessoa = new string[3];
            pessoa = banco.pessoaEspecifica(Indice);

            string CPF = pessoa[1].ToString();

            lblResp.Text = banco.deletarPessoa(CPF);

            Close();
        }
        #endregion
    }
}
