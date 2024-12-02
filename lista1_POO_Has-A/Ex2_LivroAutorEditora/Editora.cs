using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_LivroAutorEditora
{
    class Editora
    {
        public string Nome { get; set; }
        public double CNPJ { get; set; }

        public Editora(string nome, double cnpj)
        {
            this.Nome = nome;
            this.CNPJ = cnpj;
        }
    }
}
