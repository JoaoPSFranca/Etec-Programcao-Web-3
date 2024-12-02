using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_PacienteMedicoConsulta
{
    class Medico
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public DateTime DataNascimento { get; set; }
        public int CIM { get; set; }

        public Medico(string nome, string cpf, string rg, DateTime dataNascimento, int cim)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.RG = rg;
            this.DataNascimento = dataNascimento;
            this.CIM = cim;
        }

        public string ExaminarPaciente(string nome)
        {
            return "O paciente " + nome + " examinado. ";
        }

        public string DarDiagnóstico(string nome)
        {
            Random rnd = new Random();
            int doenca = rnd.Next(1, 6);
            string resposta = "";

            switch (doenca)
            {
                case (1): resposta = "O paciente " + nome + " está com covid. "; break;

                case (2): resposta = "O paciente " + nome + " está com virose. "; break;

                case (3): resposta = "O paciente " + nome + " está com dengue. "; break;

                case (4): resposta = "O paciente " + nome + " está com gripe. "; break;

                case (5): resposta = "O paciente " + nome + " está com chicungunha. "; break;
            }

            return resposta;
        }
    }
}
