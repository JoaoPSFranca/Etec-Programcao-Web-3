using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetsPessoas
{
    public partial class frmCadastrarPessoa : Form
    {
        #region Inicializar
        public frmCadastrarPessoa()
        {
            InitializeComponent();
        }
        #endregion

        #region btnCancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Formatação

        #region Ttx's

        #region txtNome
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            lblRespNome.Text = "";
        }
        #endregion

        #region txtCPF
        private void txtCPF_TextChanged(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                return;
            }
            lblRespCPF.Text = "";

            #region VerificarNumero
            if (txtCPF.Text != "")
            {
                string numero = txtCPF.Text.Substring(txtCPF.TextLength - 1, 1);
                try
                {
                    if (numero != "." && numero != "-")
                    {
                        int i = int.Parse(numero);
                    }
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
                    CPF = cpf.Substring(0, 3) + '.' + cpf.Substring(3, 1);
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
        #endregion

        #region txtTelefone
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
                return;
            
            lblRespTel.Text = "";

            #region VerificarNumero
            if (txtTelefone.Text != "")
            {
                string numero = txtTelefone.Text.Substring(txtTelefone.TextLength - 1, 1);
                try
                {
                    if (numero != "(" && numero != ")" && numero != " " && numero != "-")
                    {
                        int i = int.Parse(numero);
                    }
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
                case 4:
                    Tel = tel.Substring(0, 3) + ") " + tel.Substring(3, 1);
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

        #region txtCPF_Enter
        private void txtCPF_Enter(object sender, EventArgs e)
        {
            if (txtCPF.Text == "123.456.789-00")
            {
                txtCPF.Text = "";
                txtCPF.ForeColor = default;
            }
        }
        #endregion

        #region txtCPF_Leave
        private void txtCPF_Leave(object sender, EventArgs e)
        {
            if (txtCPF.Text == "")
            {
                txtCPF.Text = "123.456.789-00";
                txtCPF.ForeColor = Color.Gray;
            }
        }

        #endregion

        #region txtTel_Enter
        private void txtTelefone_Enter(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "(00) 12345-6789")
            {
                txtTelefone.Text = "";
                txtTelefone.ForeColor = default;
            }
        }

        #endregion

        #region txtTel_Leave
        private void txtTelefone_Leave(object sender, EventArgs e)
        {
            if (txtTelefone.Text == "")
            {
                txtTelefone.Text = "(00) 12345-6789";
                txtTelefone.ForeColor = Color.Gray;
            }
        }

        #endregion

        #endregion

        #region FormLoad
        private void frmCadastrarPessoa_Load(object sender, EventArgs e)
        {
            txtCPF.Text = "123.456.789-00";
            txtCPF.ForeColor = Color.Gray;
            txtTelefone.Text = "(00) 12345-6789";
            txtTelefone.ForeColor = Color.Gray;
        }

        #endregion

        #endregion

        #region btnAdicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Pessoas pessoas = new Pessoas();
            Pessoa pessoa = new Pessoa();

            #region Validações
            List<string> listaCPFs = pessoas.pegarCPFs();

            string CPF = txtCPF.Text;
            string Nome = txtNome.Text;
            string Telefone = txtTelefone.Text;
            
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

            #region Validar Igualdade de CPF's
            foreach (var cpf in listaCPFs)
            {
                if (cpf == CPF)
                {
                    lblRespCPF.Text = "CPF já cadastrado";
                    txtCPF.Text = "";
                    txtCPF.Focus();
                    return;
                }
            }
            #endregion

            #endregion

            if (!pessoa.adicionarPessoa(Nome, CPF, Telefone))
                lblRespNome.Text = "Deu Ruim papi";
            else { this.Close(); }
        }
        #endregion
    }
}
