using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace exemplo1_35347
{
    internal class pessoa:BD
    {
        #region pegarMaxCD
        public string pegarMaxCD()
        {
            linhaConexao = "exemplo1_35347";
            MySqlConnection conexao = abrirConexao();

            string comando = "max(cd_pessoa)+1 as proximo";
            MySqlDataReader dados = select(conexao, "pessoa", comando);

            string proxCodigo = "1";
            while (dados.Read())
            {
                if (dados["proximo"].ToString() != "")
                {
                    proxCodigo = dados["proximo"].ToString();
                }
            }
            return proxCodigo;
        }
        #endregion

        #region adicionarPessoa
        public bool adicionarPessoa(string nome, string cpf, string telefone)
        {
            linhaConexao = "exemplo1_35347";

            try
            {
                MySqlConnection conexao = abrirConexao();

                string proxCodigo = pegarMaxCD();

                string comando = "" + proxCodigo + ",'" + cpf + "','" + nome + "','" + telefone + "'";

                Insert(conexao, "pessoa", comando);

                fecharConexao(conexao);

                return true;
            }
            catch { return false; }
            
        }
        #endregion


        #region editarPessoa
        public bool editarPessoa(string nome, string cpf, string telefone, string CPF)
        {
            try
            {
                linhaConexao = "exemplo1_35347";
                MySqlConnection conexao = abrirConexao();

                string comando = "";
                comando += "	nm_cpf = '" + cpf + "', ";
                comando += "	nm_pessoa = '" + nome + "', ";
                comando += "    nm_telefone = '" + telefone + "' ";

                string where = "nm_cpf= '" + CPF + "'";

                update(conexao, "pessoa", comando, where);

                fecharConexao(conexao);

                return true;
            }
            catch { return false; }
        }
        #endregion

        #region deletarPessoa
        public bool deletarPessoa(string CPF)
        {
            try
            {
                linhaConexao = "exemplo1_35347";
                MySqlConnection conexao = abrirConexao();

                string where = "nm_cpf = '" + CPF + "';";
                delete(conexao, "pessoa", where);

                fecharConexao(conexao);

                return true;
            }
            catch { return false; }
        }
        #endregion

        #region pessoaEspecifica
        public string[] pessoaEspecifica(string nome)
        {
            string[] pessoa = new string[3];

            try
            {
                linhaConexao = "exemplo1_35347";
                MySqlConnection conexao = abrirConexao();

                string comando = "nm_pessoa as nome, nm_cpf as cpf, nm_telefone as telefone";
                MySqlDataReader dados = select(conexao, "pessoa", comando, "where nm_pessoa = '" + nome + "'; ");

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

    }
}
