using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_PacienteMedicoConsulta
{
    class Paciente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }

        public Paciente(string nome, string cpf, string rg, DateTime dataNascimento)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.DataNascimento = dataNascimento;
        }
    }
}
