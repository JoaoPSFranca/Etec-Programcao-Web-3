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

        #region formLoad
        private void frmListarPessoas_Load(object sender, EventArgs e)
        {
            Banco banco = new Banco();

            List<string> listaPessoas = banco.pegarLista();

            foreach (var humano in listaPessoas)
            {
                cbxPessoas.Items.Add(humano);
            }

            cbxPessoas.SelectedIndex = 0;
        }
        #endregion

        #region btnAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadastrarPessoa cadastrarPessoa = new frmCadastrarPessoa();
            cadastrarPessoa.Show();

            this.Visible = false;
        }
        #endregion

        #region btnAbrir
        private void btnAbrir_Click(object sender, EventArgs e)
        {
            string indice = cbxPessoas.Text;

            frmVerPessoa verPessoa = new frmVerPessoa(indice);
            verPessoa.Show();
            this.Visible = false;
        }
        #endregion
    }
}
