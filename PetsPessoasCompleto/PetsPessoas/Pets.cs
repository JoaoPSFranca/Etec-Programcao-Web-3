using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaisCulturaSantos;
using MySql.Data.MySqlClient;

namespace PetsPessoas
{
    internal class Pets : Banco
    {
        #region Listar
        public List<Pet> Listar(int codigo)
        {
            List<Pet> lista = new List<Pet>();

            string comando = "ListarPets";

            string[,] lista2 = new string[,] {
                {"vCodigoPS", codigo.ToString()}
            };

            MySqlDataReader dados = Execute(comando, lista2);

            while (dados.Read())
            {
                Pet ser = new Pet(int.Parse(dados["codigo"].ToString()), dados["nome"].ToString());
                lista.Add(ser);
            }

            Desconectar();

            return lista;
        }
        #endregion
    }
}
