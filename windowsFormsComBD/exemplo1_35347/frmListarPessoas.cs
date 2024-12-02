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
            cbxPessoas.Items.Clear();

            pessoas pessoas = new pessoas();

            List<string> listaPessoas = pessoas.pegarLista();

            foreach (var humano in listaPessoas)
            {
                cbxPessoas.Items.Add(humano);
            }

            cbxPessoas.SelectedIndex = 1;
        }
        #endregion

        #region formLoad
        private void frmListarPessoas_Load(object sender, EventArgs e)
        {
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

        #region btnAbrir
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string indice = cbxPessoas.Text;

            frmVerPessoa tela = new frmVerPessoa(indice);
            tela.ShowDialog();
            CarregarPessoas();
        }
        #endregion
    }
}
