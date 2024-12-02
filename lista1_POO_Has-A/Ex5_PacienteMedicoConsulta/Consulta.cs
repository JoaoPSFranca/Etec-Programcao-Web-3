using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5_PacienteMedicoConsulta
{
    class Consulta
    {
        public DateTime DataConsultaStart { get; set; }
        public DateTime DataConsultaEnd { get; set; }
        public Paciente Paciente { get; set; }
        public Medico Medico { get; set; }

        public Consulta(Paciente paciente, Medico medico, DateTime dataConsultaStart, DateTime dataConsultaEnd)
        {
            this.Paciente = paciente;
            this.Medico = medico;
            this.DataConsultaStart = dataConsultaStart;
            this.DataConsultaEnd = dataConsultaEnd;
        }

        public string IniciarConsulta(DateTime data)
        {
            return "A consulta foi iniciada em " + data.ToString();
        }

        public string EncerrarConsulta(DateTime data)
        {
            return "A consulta foi encerrada em " + data.ToString();
        }
    }
}
