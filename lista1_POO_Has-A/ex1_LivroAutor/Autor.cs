using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_LivroAutor
{
    class Autor
    {
        public string CPF { get; set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }

        public Autor(string cpf, string nome, DateTime data)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.DataNascimento = data;
        }
    }
}
