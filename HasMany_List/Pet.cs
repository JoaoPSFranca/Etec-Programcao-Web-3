using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao_Prova
{
    class Pet
    {
        private string _nome;
        private DateTime _nascimento;
        private double _peso;
        private Raca _raca;

        public string Nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public DateTime Nascimento
        {
            get { return _nascimento; }
            set { _nascimento = value; }
        }

        //public string Nascimento
        //{
        //    get { return _nascimento.ToShortDateString(); }
        //    set { _nascimento = DateTime.Parse(value); }
        //}
    
        public double Peso
        {
            get { return _peso; }
            set { _peso = value; }
        }

        public Raca Raca
        {
            get { return _raca; }
            set { _raca = value; }
        }

        public Pet(string nome, DateTime nascimento, double peso, Raca raca)
        {
            Nome = nome;
            Nascimento = nascimento;
            Peso = peso;
            Raca = raca;
        }

        public string EmitirSom()
        {
            return "O Pet emitiu som";
        }

        public string Dormir()
        {
            return "Pet dormiu";
        }

    }
}
