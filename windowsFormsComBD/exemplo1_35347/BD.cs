using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace exemplo1_35347
{
    class BD
    {
        #region _nomeProjeto
        private string _linhaConexao;
        public string linhaConexao
        {
            get { return _linhaConexao; }
            set { _linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=" + value + ""; }
        }
        #endregion

        #region abrirConexao
        public MySqlConnection abrirConexao() {
            try
            {
                MySqlConnection conexao = new MySqlConnection(_linhaConexao);
                conexao.Open();
                return conexao;
            }
            catch{
                return null;
            }            

        }
        #endregion

        #region fecharConexao
        public bool fecharConexao(MySqlConnection conexao)
        {
            try
            {
                conexao.Close();
                return true;
            }
            catch
            {
                return false;
            }

        }
        #endregion

        #region selects

        #region Select Clássico
        public MySqlDataReader select(MySqlConnection conexao, string tabela, string oque, string where)
        {

            try
            {
                string comando = "select " + oque + " from " + tabela + " " + where + ";";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader dados = cSQL.ExecuteReader();

                return dados;
            }
            catch { return null; }
        }
        #endregion

        #region Select Completo
        public MySqlDataReader select(MySqlConnection conexao, string tabela, string oque)
        {

            try
            {
                string comando = "select " + oque + " from " + tabela + "; ";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader dados = cSQL.ExecuteReader();

                return dados;
            }
            catch { return null; }
        }
        #endregion

        #region Select Snippet
        public MySqlDataReader select(MySqlConnection conexao, string tabela)
        {

            try
            {
                string comando = "select * from " + tabela + ";";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader dados = cSQL.ExecuteReader();

                return dados;
            }
            catch { return null; }
        }
        #endregion

        #endregion

        #region Insert
        public bool Insert(MySqlConnection conexao, string tabela, string valores)
        {
            try
            {
                string comando = "Insert into " + tabela + " values (" + valores + ")";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();

                return true;
            }
            catch { return false; }
        }
        #endregion

        #region update
        public bool update(MySqlConnection conexao, string tabela, string sets, string where)
        {
            try
            {
                string comando = "update " + tabela + " set " + sets + " where " + where + ";";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();

                return true;
            }
            catch { return false; }
        }
        #endregion

        #region Delete

        #region deleteFull
        public bool delete(MySqlConnection conexao, string tabela, string where)
        {
            try
            {
                string comando = "delete from " + tabela + " where " + where + ";";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();

                return true;
            }
            catch{ return false; }
        }
        #endregion

        #region Delete Snippet
        public bool delete(MySqlConnection conexao, string tabela)
        {
            try
            {
                string comando = "delete from " + tabela + ";";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();

                return true;
            }
            catch { return false; }
        }
        #endregion

        #endregion
    }
}
