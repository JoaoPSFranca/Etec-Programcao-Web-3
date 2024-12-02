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
            pessoa pessoa = new pessoa();
            string[] humano = new string[3];
            humano = pessoa.pessoaEspecifica(Indice);

            string Nome = humano[0];
            string CPF = humano[1];
            string Telefone = humano[2];

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
            pessoas pessoas = new pessoas();
            pessoa pessoa = new pessoa();

            #region Validar
            string[] humano = new string[3];
            humano = pessoa.pessoaEspecifica(Indice);

            string Nome = humano[0];
            string CPF = humano[1];
            string Telefone = humano[2];

            if (txtNome.Text == Nome)
            {
                lblRespNome.Text = "Nome não pode ser igual ao anterior";
                txtNome.Focus();
                return;
            }

            if (txtCPF.Text == CPF)
            {
                lblRespCPF.Text = "CPF não pode ser igual ao anterior";
                txtCPF.Focus();
                return;
            }

            if (txtTelefone.Text == Telefone)
            {
                lblRespTel.Text = "Telefone não pode ser igual ao anterior";
                txtTelefone.Focus();
                return;
            }
            #endregion

            humano = new string[3];
            humano = pessoa.pessoaEspecifica(Indice);

            List<string> listaCPFs = pessoas.pegarCPFs();

            CPF = humano[1].ToString();
            string Cpf = txtCPF.Text;
            Nome = txtNome.Text;
            Telefone = txtTelefone.Text;

            #region Validacoes
            if (txtNome.Text == "")
            {
                lblRespNome.Text = "nome não pode ser vazio";
                txtNome.Focus();
                return;
            }

            #region CPF
            if (txtCPF.Text == "")
            {
                lblRespCPF.Text = "CPF não pode ser vazio";
                txtCPF.Focus();
                return;
            }
            else
            {
                if (txtCPF.TextLength < 14)
                {
                    lblRespCPF.Text = "CPF não pode ter menos de 11 números";
                    txtCPF.Focus();
                    return;
                }
            }
            #endregion

            #region Tel
            if (txtTelefone.Text == "")
            {
                lblRespTel.Text = "Telefone não pode ser vazio";
                txtTelefone.Focus();
                return;
            }
            else
            {
                if (txtTelefone.TextLength < 15)
                {
                    lblRespTel.Text = "Telefone não pode ter menos de 11 números";
                    txtTelefone.Focus();
                    return;
                }
            }
            #endregion

            #endregion

            foreach (var cpf in listaCPFs)
            {
                if (cpf == Cpf && cpf != CPF)
                {
                    lblRespCPF.Text = "CPF já cadastrado";
                    txtCPF.Text = "";
                    txtCPF.Focus();
                    return;
                }
            }

            pessoa.editarPessoa(Nome, Cpf, Telefone, CPF);

            Close();
        }
        #endregion

        #region btnExcluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            pessoas pessoas = new pessoas();
            pessoa pessoa = new pessoa();

            string[] humano = new string[3];
            humano = pessoa.pessoaEspecifica(Indice);

            string CPF = humano[1].ToString();

            pessoa.deletarPessoa(CPF);

            Close();
        }
        #endregion

        #region Txt's
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblRespNome.Text = "";
        }

        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            lblRespCPF.Text = "";

            #region VerificarNumero
            if (txtCPF.Text != "")
            {
                string numero = txtCPF.Text.Substring(txtCPF.TextLength - 1, 1);
                try
                {
                    int i = int.Parse(numero);
                }
                catch
                {
                    txtCPF.Text = txtCPF.Text.Substring(0, txtCPF.TextLength - 1);
                    lblRespCPF.Text = "Digite apenas números";
                    txtCPF.Select(txtCPF.TextLength, 0);
                    return;
                }
            }
            #endregion

            #region Formatar
            #region Variáveis
            string cpf = txtCPF.Text;
            string CPF = "";
            #endregion

            #region Try
            try
            {
                int i = int.Parse(cpf.Substring(cpf.Length - 1, 1));
            }
            catch
            {
                return;
            }
            #endregion

            #region Switch
            switch (cpf.Length)
            {
                case 4:
                    CPF = cpf.Substring(0,3) + '.' + cpf.Substring(3, 1);
                    txtCPF.Text = CPF;
                    txtCPF.Select(txtCPF.TextLength, 0);
                    break;
                case 8:
                    CPF = cpf.Substring(0, 7) + '.' + cpf.Substring(7, 1);
                    txtCPF.Text = CPF;
                    txtCPF.Select(txtCPF.TextLength, 0);
                    break;
                case 12:
                    CPF = cpf.Substring(0, 11) + '-' + cpf.Substring(11, 1);
                    txtCPF.Text = CPF;
                    txtCPF.Select(txtCPF.TextLength, 0);
                    break;
            }
            #endregion
            #endregion
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            lblRespTel.Text = "";

            #region VerificarNumero
            if (txtTelefone.Text != "")
            {
                string numero = txtTelefone.Text.Substring(txtTelefone.TextLength - 1, 1);
                try
                {
                    int i = int.Parse(numero);
                }
                catch
                {
                    txtTelefone.Text = txtTelefone.Text.Substring(0, txtTelefone.TextLength - 1);
                    lblRespTel.Text = "Digite apenas números";
                    txtTelefone.Select(txtTelefone.TextLength, 0);
                    return;
                }
            }
            #endregion

            #region Formatar
            #region Variáveis
            string tel = txtTelefone.Text;
            string Tel = "";
            #endregion

            #region Try
            try
            {
                int i = int.Parse(tel.Substring(tel.Length - 1, 1));
            }
            catch
            {
                return;
            }
            #endregion

            #region Switch
            switch (tel.Length)
            {
                case 1:
                    Tel = "(" + tel.Substring(0, 1);
                    txtTelefone.Text = Tel;
                    txtTelefone.Select(txtTelefone.TextLength, 0);
                    break;
                case 3:
                    Tel = tel.Substring(0, 3) + ") ";
                    txtTelefone.Text = Tel;
                    txtTelefone.Select(txtTelefone.TextLength, 0);
                    break;
                case 11:
                    Tel = tel.Substring(0, 10) + "-" + tel.Substring(10, 1);
                    txtTelefone.Text = Tel;
                    txtTelefone.Select(txtTelefone.TextLength, 0);
                    break;
            }
            #endregion
            #endregion
        }
        #endregion
    }
}
