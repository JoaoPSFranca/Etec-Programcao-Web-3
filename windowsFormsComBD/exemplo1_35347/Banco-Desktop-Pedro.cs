using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace exemplo1_35347
{
    class Banco
    {
         #region List
        public List<string> pegarLista()
        {
            List<string> listaPessoas = new List<string>();

            string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=ex1_35347";

            try
            {
                MySqlConnection conexao = new MySqlConnection(linhaConexao);
                conexao.Open();

                string comando = "select nm_pessoa as nome, nm_cpf as cpf, nm_telefone as telefone from pessoa order by nm_pessoa;";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader dados = cSQL.ExecuteReader();

                while (dados.Read())
                {
                    listaPessoas.Add(dados["nome"].ToString());
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                listaPessoas.Add(ex.Message);
            }

            return listaPessoas;

        }
        #endregion

        public bool CadastrarPessoa(string nome, string cpf, string telefone)
        {
            string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=ex1_35347";

            try
            {
                MySqlConnection conexao = new MySqlConnection(linhaConexao);
                conexao.Open();

                string comando = "insert into pessoa values ('" + cpf + "', '" + nome + "', '" + telefone + "');";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();

                conexao.Close();
            }
            catch
            {
                return false;
            }

            return true;
        }
    }
}
