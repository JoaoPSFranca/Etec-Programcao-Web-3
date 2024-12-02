using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MaisCulturaSantos
{
    public class Banco
    {
        private string LinhaConexao { get; set; }
        MySqlConnection conexao = null;

        #region constructor
        public Banco()
        {
            LinhaConexao = Conexao.linhaConexao;
        }
        #endregion

        #region Conectar
        private void Conectar()
        {
            conexao = new MySqlConnection(LinhaConexao);
            try
            {
                conexao.Open();
            }
            catch
            {
                throw new Exception("Erro na conexão com o Servidor.");
            }
        }
        #endregion

        #region Desconectar
        protected void Desconectar()
        {
            if (conexao != null)
                if (conexao.State == System.Data.ConnectionState.Open)
                    conexao.Close();

        }
        #endregion

        #region Execute
        protected MySqlDataReader Execute(string comando, string[,] lista)
        {
            try
            {
                Conectar();
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.CommandType = System.Data.CommandType.StoredProcedure;

                if (lista.GetLength(0) != 0)
                {
                    for (int i = 0; i < lista.GetLength(0); i++)
                    {
                        cSQL.Parameters.Add(new MySqlParameter(lista[i, 0], lista[i, 1]));
                    }
                }

                return cSQL.ExecuteReader();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }

        #region Execute sem lista
        protected MySqlDataReader Execute(string comando)
        {
            try
            {
                Conectar();
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.CommandType = System.Data.CommandType.StoredProcedure;

                return cSQL.ExecuteReader();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion

        #endregion

        #region  NonQuerry
        protected void NonQuerry(string comando, string [,] lista)
        {
            try
            {
                Conectar();
                MySqlCommand cSQL = new MySqlCommand(comando, conexao);
                cSQL.CommandType = System.Data.CommandType.StoredProcedure;

                for (int i = 0; i < lista.GetLength(0); i++)
                {
                    string teste = lista[i, 0];
                    string teste2 = lista[i, 1];
                    cSQL.Parameters.Add(new MySqlParameter(teste, teste2));
                }

                cSQL.ExecuteNonQuery();
                Desconectar();
            }
            catch (Exception erro)
            {
                throw erro;
            }
        }
        #endregion
    }
}
