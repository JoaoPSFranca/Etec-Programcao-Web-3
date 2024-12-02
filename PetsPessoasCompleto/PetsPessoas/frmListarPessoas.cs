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
    public partial class frmListarPessoas : Form
    {
        #region Inicializar
        public frmListarPessoas()
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

        #region btnPessoa
        private void btnPessoa_Click(object sender, EventArgs e)
        {
            int i = int.Parse(cbxPessoas.SelectedValue.ToString());

            frmVerPessoa tela = new frmVerPessoa(i);
            tela.ShowDialog();
            CarregarPessoas();
        }
        #endregion

        #region btnPets
        private void btnPets_Click(object sender, EventArgs e)
        {
            int i = int.Parse(cbxPessoas.SelectedValue.ToString());

            frmVerPets tela = new frmVerPets(i);
            tela.ShowDialog();
            CarregarPessoas();
        }
        #endregion

        #region btnAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadastrarPessoa tela = new frmCadastrarPessoa();
            tela.ShowDialog();
            CarregarPessoas();
        }
        #endregion

        #region FormLoad
        private void frmListarPessoas_Load(object sender, EventArgs e)
        {
            CarregarPessoas();
        }
        #endregion
    }
}
