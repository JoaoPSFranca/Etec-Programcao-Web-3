using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MaisCulturaSantos;

namespace PetsPessoas
{
    internal class Racas : Banco
    {
        #region Listar
        public List<Raca> Listar()
        {
            List<Raca> lista = new List<Raca>();

            string comando = "ListarRacas";

            MySqlDataReader dados = Execute(comando);

            while (dados.Read())
            {
                Raca ser = new Raca(int.Parse(dados["codigo"].ToString()), dados["nome"].ToString());
                lista.Add(ser);
            }

            Desconectar();

            return lista;
        }
        #endregion
    }
}
