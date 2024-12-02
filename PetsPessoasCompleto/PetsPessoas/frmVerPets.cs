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
    public partial class frmVerPets : Form
    {
        int codigoPS = 0;

        #region Inicializar
        public frmVerPets(int i)
        {
            InitializeComponent();

            codigoPS = i;
        }
        #endregion

        #region btnBack
        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region CarregarPets
        void CarregarPets()
        {
            Pets pets = new Pets();

            List<Pet> lista = pets.Listar(codigoPS);
            cbxPets.ValueMember = "CD";
            cbxPets.DisplayMember = "Nome";
            cbxPets.DataSource = lista;
        }

        void CarregarPetEspecifico()
        {
            if (cbxPets.SelectedValue != null)
            {
                int codigoP = int.Parse(cbxPets.SelectedValue.ToString());

                Pet pet = new Pet();
                string[] animal = new string[4];
                animal = pet.petEspecifico(codigoP, codigoPS);

                string dono = animal[0];
                string raca = animal[1];
                string peso = animal[2];
                string data = animal[3];

                txtDono.Text = dono;
                txtRaca.Text = raca;
                txtPeso.Text = peso + "kg";
                txtData.Text = data;
            }
            
        }
        #endregion

        #region FormLoad
        private void frmVerPets_Load(object sender, EventArgs e)
        {
            CarregarPets();
            CarregarPetEspecifico();
        }
        #endregion

        #region cbxPets
        private void cbxPets_SelectedIndexChanged(object sender, EventArgs e)
        {
            CarregarPetEspecifico();
        }
        #endregion

        #region btnSave
        private void btnSave_Click(object sender, EventArgs e)
        {
            int codigoP = int.Parse(cbxPets.SelectedValue.ToString());

            Pet pet = new Pet();
            Pets pets = new Pets();

            #region Validar Igualdade
            string[] animal = new string[4];
            animal = pet.petEspecifico(codigoP, codigoPS);

            string peso = animal[2] + "kg";
            string data = animal[3];

            if (txtPeso.Text == peso && txtData.Text == data)
            {
                lblRespPeso.Text = "Deve haver pelo menos uma alteração para salvar!";
                txtPeso.Focus();
                return;
            }
            #endregion

            #region Validar
            double peso2 = 0;

            if (txtPeso.Text == "")
            {
                lblRespPeso.Text = "Favor inserir um peso!";
                txtPeso.Focus();
                return;
            }
            try
            {
                peso2 = double.Parse(txtPeso.Text);
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

            #region Formatar peso
            int X = 1;
            double Peso = 0;

            while (X != 0)
            {
                try
                {
                    Peso = double.Parse(txtPeso.Text.Substring(0, X));
                    X++;
                }
                catch
                {
                    X = 0;
                }
            }
            #endregion

            #region Formatar Data
            data = txtData.Text;
            
            data = data.Substring(data.Length - 4, 4) + "-" + data.Substring(3, 2) + "-" + data.Substring(0, 2);
            #endregion

            pet.editarPet(Peso, data, codigoP, codigoPS);

            this.Close();
        }
        #endregion

        #region btnExcluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int codigoP = int.Parse(cbxPets.SelectedValue.ToString());

            Pet pet = new Pet();

            pet.deletarPet(codigoP, codigoPS);

            CarregarPets();
            CarregarPetEspecifico();
        }
        #endregion

        #region btnAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadastrarPet tela = new frmCadastrarPet();
            tela.ShowDialog();
            CarregarPets();
            CarregarPetEspecifico();
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

        #region txtPeso
        private void txtPeso_TextChanged(object sender, EventArgs e)
        {
            if (txtPeso.Text != "")
            {
                lblRespPeso.Text = "";
            }
        }
        #endregion
    }
}
