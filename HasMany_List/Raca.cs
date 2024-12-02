using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao_Prova
{
    class Raca
    {
        private string _nome;
        private string _porte;

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string valorEntrada)
        {
            if (valorEntrada == "")
            {
                throw new Exception("Nome não pode ficar em branco");
            }
            else
            {
                _nome = valorEntrada;
            }
        }

        public string GetPorte()
        {
            return _porte;
        }

        public void SetPorte(string valorEntrada)
        {
            _porte = valorEntrada;
        }

        public Raca()
        { 
        }
    }
}
