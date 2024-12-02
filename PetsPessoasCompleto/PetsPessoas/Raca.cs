using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsPessoas
{
    internal class Raca
    {
        public Raca(int cd, string nome)
        {
            this.CD = cd;
            this.Nome = nome;
        }

        public Raca()
        {

        }

        public int CD { get; set; }
        public string Nome { get; set; }
    }
}
