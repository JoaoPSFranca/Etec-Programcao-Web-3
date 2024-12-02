using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaisCulturaSantos;
using MySql.Data.MySqlClient;


namespace PetsPessoas
{
    internal class Pessoa : Banco
    {
        public Pessoa(int cd, string nome)
        {
            this.Cd = cd;
            this.Nome = nome;
        }

        public Pessoa()
        {
        }

        public int Cd { get; set; }
        public string Nome { get; set; }

        #region adicionarPessoa
        public bool adicionarPessoa(string nome, string cpf, string telefone)
        {
            try
            {
                string comando = "adicionarPessoas";

                string [,] lista = new string [,]
                {
                    {"vCpf", cpf},
                    {"vNome", nome},
                    {"vTelefone", telefone}
                };

                NonQuerry(comando, lista);

                return true;
            }
            catch { return false; }

        }
        #endregion

        #region pessoaEspecifica
        public string[] pessoaEspecifica(int codigo)
        {
            string[] pessoa = new string[3];

            try
            {

                string comando = "pessoaEspecifica";

                string[,] lista = new string[,]
                {
                    {"vCode", codigo.ToString()}
                };

                MySqlDataReader dados = Execute(comando, lista);

                while (dados.Read())
                {
                    pessoa[0] = dados["nome"].ToString();
                    pessoa[1] = dados["cpf"].ToString();
                    pessoa[2] = dados["telefone"].ToString();
                }

                Desconectar();
            }
            catch (Exception ex)
            {
                pessoa[0] = ex.Message;
                pessoa[1] = "";
                pessoa[2] = "";
            }

            return pessoa;
        }
        #endregion

        #region editarPessoa
        public bool editarPessoa(string nome, string telefone, int codigo)
        {
            try
            {
                string comando = "editarPessoa";

                string[,] lista = new string[,]
                {
                    {"vNome", nome},
                    {"vTelefone", telefone},
                    {"vCode", codigo.ToString()}
                };

                NonQuerry(comando, lista);

                return true;
            }
            catch { return false; }
        }
        #endregion

        #region deletarPessoa
        public bool deletarPessoa(int codigo)
        {
            try
            {
                string comando = "deletarPessoa";

                string[,] lista = new string[,]
                {
                    {"vCode", codigo.ToString()}
                };

                NonQuerry(comando, lista);

                return true;
            }
            catch { return false; }
        }
        #endregion
    }
}
