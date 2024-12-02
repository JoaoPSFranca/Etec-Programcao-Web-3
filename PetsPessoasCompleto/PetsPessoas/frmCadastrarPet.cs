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
    public partial class frmCadastrarPet : Form
    {
        #region Inicializar
        public frmCadastrarPet()
        {
            InitializeComponent();
        }
        #endregion

        #region CarregarPessoas
        void CarregarPessoas()
        {
            Pessoas pessoas = new Pessoas();

            List<Pessoa> lista = pessoas.Listar();
            cbxPessoas.ValueMember = "Cd";
            cbxPessoas.DisplayMember = "Nome";
            cbxPessoas.DataSource = lista;
        }
        #endregion

        #region CarregarRacas
        void CarregarRacas()
        {
            Racas racas = new Racas();

            List<Raca> lista = racas.Listar();
            cbxRaca.ValueMember = "CD";
            cbxRaca.DisplayMember = "Nome";
            cbxRaca.DataSource = lista;
        }
        #endregion

        #region btnCancelar
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region formLoad
        private void frmCadastrarPet_Load(object sender, EventArgs e)
        {
            CarregarPessoas();
            CarregarRacas();
        }

        #endregion

        #region txtNome
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if (txtNome.Text != "")
            {
                lblRespNome.Text = "";
            }
        }
        #endregion

        #region txtPeso
        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if (txtPeso.Text != "")
            {
                lblRespPeso.Text = "";
            }
        }
        #endregion

        #region txtData
        private void txtData_TextChanged(object sender, EventArgs e)
        {
            if (txtData.Text != "")
            {
                lblRespData.Text = "";
            }

            #region VerificarNumero
            if (txtData.Text != "")
            {
                string numero = txtData.Text.Substring(txtData.TextLength - 1, 1);
                try
                {
                    if (numero != "/")
                    {
                        int i = int.Parse(numero);
                    }
                }
                catch
                {
                    txtData.Text = txtData.Text.Substring(0, txtData.TextLength - 1);
                    lblRespData.Text = "Digite apenas números";
                    txtData.Select(txtData.TextLength, 0);
                    return;
                }
            }
            #endregion

            #region Formatar

            #region Variáveis
            string data = txtData.Text;
            string Data = "";
            #endregion

            #region Try
            try
            {
                int i = int.Parse(data.Substring(data.Length - 1, 1));
            }
            catch
            {
                return;
            }
            #endregion

            #region Switch
            switch (data.Length)
            {
                case 3:
                    Data = data.Substring(0, 2) + "/" + data.Substring(2, 1);
                    txtData.Text = Data;
                    txtData.Select(txtData.TextLength, 0);
                    break;
                case 6:
                    Data = data.Substring(0, 5) + "/" + data.Substring(5, 1);
                    txtData.Text = Data;
                    txtData.Select(txtData.TextLength, 0);
                    break;
            }
            #endregion

            #endregion
        }
        #endregion

        #region btnAdicionar
        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            double peso = 0;

            #region Validar
            if (txtNome.Text == "")
            {
                lblRespNome.Text = "Favor inserir um nome!";
                txtNome.Focus();
                return;
            }

            if (txtPeso.Text == "")
            {
                lblRespPeso.Text = "Favor inserir um peso!";
                txtPeso.Focus();
                return;
            }
            try
            {
                peso = double.Parse(txtPeso.Text);
            }
            catch
            {
                lblRespPeso.Text = "Favor inserir apenas números em 'peso'!";
                txtPeso.Text = "";
                txtPeso.Focus();
                return;
            }

            if (txtData.Text == "")
            {
                lblRespData.Text = "Favor inserir uma data!";
                txtData.Focus();
                return;
            }
            #endregion

            int codigoR = int.Parse(cbxRaca.SelectedValue.ToString());
            int codigoPS = int.Parse(cbxPessoas.SelectedValue.ToString());
            string nome = txtNome.Text;

            #region Formatar Data
            string data = txtData.Text;

            data = data.Substring(data.Length - 4, 4) + "-" + data.Substring(3, 2) + "-" + data.Substring(0, 2);
            #endregion

            Pet pet = new Pet();
            pet.adicionarPet(codigoPS, codigoR, nome, peso, data);

            this.Close();
        }
        #endregion
    }
}
