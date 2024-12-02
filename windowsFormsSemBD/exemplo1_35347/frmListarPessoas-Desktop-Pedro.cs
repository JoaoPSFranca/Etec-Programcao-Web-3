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
            cbxPessoas.Items.Clear();

            Banco banco = new Banco();
            Pessoa pessoa = new Pessoa();

            List<string> listaPessoas = banco.pegarLista();

            foreach (var huamno in listaPessoas)
            {
                cbxPessoas.Items.Add(huamno);
            }
        }
        #endregion

        #region btnAdd
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmCadastrarPessoa cadastrarPessoa = new frmCadastrarPessoa();

            cadastrarPessoa.ShowDialog();
        }
        #endregion

        private void btnAbrir_Click(object sender, EventArgs e)
        {

        }
    }
}
