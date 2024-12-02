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
        #region pegarLista
        public List<string> pegarLista()
        {
            List<string> listaPessoas = new List<string>();

            try
            {
                string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=exemplo1_35347";
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

        #region adicionarPessoa
        public string adicionarPessoa(string nome, string cpf, string telefone)
        {
            try
            {
                string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=exemplo1_35347";
                MySqlConnection conexao = new MySqlConnection(linhaConexao);
                conexao.Open();

                string comando = "insert into pessoa values ('" + cpf + "', '" + nome + "', '" + telefone + "');";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "deu certo";
        }
        #endregion

        #region pegarCPFs
        public List<string> pegarCPFs()
        {
            List<string> listaCPFs = new List<string>();

            try
            {
                string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=exemplo1_35347";
                MySqlConnection conexao = new MySqlConnection(linhaConexao);
                conexao.Open();

                string comando = "select nm_pessoa as nome, nm_cpf as cpf, nm_telefone as telefone from pessoa;";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader dados = cSQL.ExecuteReader();

                while (dados.Read())
                {
                    listaCPFs.Add(dados["cpf"].ToString());
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                listaCPFs.Add(ex.Message);
            }

            return listaCPFs;

        }
        #endregion

        #region editarPessoa
        public string editarPessoa(string nome, string cpf, string telefone, string CPF)
        {

            try
            {
                string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=exemplo1_35347";
                MySqlConnection conexao = new MySqlConnection(linhaConexao);
                conexao.Open();

                string comando = "update pessoa ";
                comando += "set ";
                comando += "	nm_cpf = '" + cpf + "', ";
                comando += "	nm_pessoa = '" + nome + "', ";
                comando += "    nm_telefone = '" + telefone + "' ";
                comando += "where nm_cpf= '" + CPF + "';";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "";
        }
        #endregion

        #region pessoaEspecifica
        public string[] pessoaEspecifica(string nome)
        {
            string[] pessoa = new string[3];

            try
            {
                string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=exemplo1_35347";
                MySqlConnection conexao = new MySqlConnection(linhaConexao);
                conexao.Open();

                string comando = "select nm_pessoa as nome, nm_cpf as cpf, nm_telefone as telefone from pessoa where nm_pessoa = '" + nome + "';";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                MySqlDataReader dados = cSQL.ExecuteReader();

                while (dados.Read())
                {
                    pessoa[0] = dados["nome"].ToString();
                    pessoa[1] = dados["cpf"].ToString();
                    pessoa[2] = dados["telefone"].ToString();
                }

                conexao.Close();
            }
            catch (Exception ex)
            {
                pessoa[0] = ex.Message;
                pessoa[1] = "";
                pessoa[2] = "";

                return pessoa;
            }

            return pessoa;
        }
        #endregion

        #region deletarPessoa
        public string deletarPessoa(string CPF)
        {
            try
            {
                string linhaConexao = "SERVER=localhost;UID=root;PASSWORD=root;DATABASE=exemplo1_35347";
                MySqlConnection conexao = new MySqlConnection(linhaConexao);
                conexao.Open();

                string comando = "delete from pessoa where nm_cpf = '" + CPF + "';";
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.ExecuteNonQuery();

                conexao.Close();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return "";
        }
        #endregion
    }
}
