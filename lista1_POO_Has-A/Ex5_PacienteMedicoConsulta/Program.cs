using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_PacienteMedicoConsulta
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime nascimentoPaciente = new DateTime(1993, 11, 15);
            DateTime nascimentoMedico = new DateTime(1970, 12, 21);
            DateTime dataConsultaStart = new DateTime(2015,10, 16, 14, 09, 25);
            DateTime dataConsultaEnd = new DateTime(2015, 10, 16, 14, 15, 58);

            Paciente paciente = new Paciente("Andressa Figueiras Debossam", "064.827.732-14", "24.643.559-8", nascimentoPaciente);
            Medico medico = new Medico("Munique Pinheiro Dinis", "038.536.132-76", "47.117.424-5", nascimentoMedico, 17747);
            Consulta consulta = new Consulta(paciente, medico, dataConsultaStart, dataConsultaEnd);

            Console.WriteLine("Paciente: ");
            Console.WriteLine("Nome: " + paciente.Nome);
            Console.WriteLine("CPF: " + paciente.CPF);
            Console.WriteLine("RG: " + paciente.RG);
            Console.WriteLine("Data de Nascimento: " + paciente.DataNascimento);

            Console.WriteLine();
            Console.WriteLine("Médico: ");
            Console.WriteLine("Nome: " + medico.Nome);
            Console.WriteLine("CPF: " + medico.CPF);
            Console.WriteLine("RG: " + medico.RG);
            Console.WriteLine("Data de Nascimento: " + medico.DataNascimento);
            Console.WriteLine("CIM: " + medico.CIM);

            Console.WriteLine();
            Console.WriteLine("Deseja iniciar a consulta? ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(consulta.IniciarConsulta(dataConsultaStart));

            Console.WriteLine();
            Console.WriteLine("Deseja examinar o paciente? ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(medico.ExaminarPaciente(paciente.Nome));

            Console.WriteLine();
            Console.WriteLine(medico.DarDiagnóstico(paciente.Nome));

            Console.WriteLine();
            Console.WriteLine("Deseja encerrar a consulta? ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(consulta.EncerrarConsulta(dataConsultaEnd));

            Console.ReadKey();

        }
    }
}
