using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace exemplo1_35347
{
    internal class pessoas:BD
    {
        #region pegarCPFs
        public List<string> pegarCPFs()
        {
            List<string> listaCPFs = new List<string>();

            try
            {
                linhaConexao = "exemplo1_35347";
                MySqlConnection conexao = abrirConexao();

                string comando = "nm_pessoa as nome, nm_cpf as cpf, nm_telefone as telefone";
                MySqlDataReader dados = select(conexao, "pessoa", comando);

                while (dados.Read())
                {
                    listaCPFs.Add(dados["cpf"].ToString());
                }

                fecharConexao(conexao);
            }
            catch (Exception ex)
            {
                listaCPFs.Add(ex.Message);
            }

            return listaCPFs;

        }
        #endregion

        #region pegarLista
        public List<string> pegarLista()
        {
            List<string> listaPessoas = new List<string>();

            linhaConexao = "exemplo1_35347";

            MySqlConnection conexao = abrirConexao();

            string comando = "nm_pessoa as nome";
            MySqlDataReader dados = select(conexao, "pessoa", comando, "order by nm_pessoa");

            while (dados.Read())
            {
                listaPessoas.Add(dados["nome"].ToString());
            }

            fecharConexao(conexao);

            return listaPessoas;
        }
        #endregion
    }
}
