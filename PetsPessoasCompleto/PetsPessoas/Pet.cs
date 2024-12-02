using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaisCulturaSantos;
using MySql.Data.MySqlClient;

namespace PetsPessoas
{
    internal class Pet : Banco
    {
        public int CD { get; set; }
        public string Nome { get; set; }

        public Pet(int cd, string nome)
        {
            this.CD = cd;
            this.Nome = nome;
        }

        public Pet()
        {

        }

        #region petEspecifico
        public string[] petEspecifico(int codigoP, int codigoPS)
        {
            string[] pet = new string[4];

            try
            {
                string comando = "petEspecifico";

                string[,] lista = new string[,]
                {
                    {"vCodigoP", codigoP.ToString()},
                    {"vCodigoPS", codigoPS.ToString()}
                };

                MySqlDataReader dados = Execute(comando, lista);

                while (dados.Read())
                {
                    pet[0] = dados["dono"].ToString();
                    pet[1] = dados["raca"].ToString();
                    pet[2] = dados["peso"].ToString();
                    pet[3] = dados["data"].ToString();
                }

                Desconectar();
            }
            catch (Exception ex)
            {
                pet[0] = ex.Message;
                pet[1] = "";
                pet[2] = "";
                pet[3] = "";
                pet[4] = "";
            }

           return pet;
        }
        #endregion

        #region editarPet
        public bool editarPet(double peso, string data, int codigoP, int codigoPS)
        {
            try
            {
                string comando = "editarPet";

                string[,] lista = new string[,]
                {
                    {"vPeso", peso.ToString()},
                    {"vData", data},
                    {"vCodigoP", codigoP.ToString()},
                    {"vCodigoPS", codigoPS.ToString()}
                };

                NonQuerry(comando, lista);

                return true;
            }
            catch { return false; }
        }
        #endregion

        #region deletarPet
        public bool deletarPet(int codigoP, int codigoPS)
        {
            try
            {
                string comando = "deletarPet";

                string[,] lista = new string[,]
                {
                    {"vCodigoP", codigoP.ToString()},
                    {"vCodigoPS", codigoPS.ToString()}
                };

                NonQuerry(comando, lista);

                return true;
            }
            catch { return false; }
        }
        #endregion

        #region adicionarPet
        public bool adicionarPet(int codigoPS, int codigoR, string nome, double peso, string data)
        {
            try
            {
                string comando = "adicionarPet";

                string[,] lista = new string[,]
                {
                    {"vCodigoPS", codigoPS.ToString()},
                    {"vCodigoR", codigoR.ToString()},
                    {"vNome", nome},
                    {"vPeso", peso.ToString()},
                    {"vData", data}
                };

                NonQuerry(comando, lista);

                return true;
            }
            catch
            {
                return false;
            }
        }
        #endregion

    }
}
