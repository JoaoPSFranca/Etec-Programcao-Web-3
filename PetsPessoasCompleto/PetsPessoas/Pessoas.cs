using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MaisCulturaSantos;

namespace PetsPessoas
{
    internal class Pessoas:Banco
    {
        #region Listar
        public List<Pessoa> Listar(){
            List<Pessoa> lista = new List<Pessoa>();

            string comando = "ListarPessoas";

            MySqlDataReader dados = Execute(comando);

            while (dados.Read())
            {
                Pessoa ser = new Pessoa(int.Parse(dados["codigo"].ToString()), dados["nome"].ToString());
                lista.Add(ser);
            }

            Desconectar();

            return lista;
        }
        #endregion

        #region pegarCPFs
        public List<string> pegarCPFs()
        {
            List<string> listaCPFs = new List<string>();

            try
            {
                string comando = "ListarPessoas";
                MySqlDataReader dados = Execute(comando);

                while (dados.Read())
                {
                    listaCPFs.Add(dados["cpf"].ToString());
                }

                Desconectar();
            }
            catch (Exception ex)
            {
                listaCPFs.Add(ex.Message);
            }

            return listaCPFs;

        }
        #endregion
    }
}
