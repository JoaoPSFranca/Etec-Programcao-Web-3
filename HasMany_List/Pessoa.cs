using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao_Prova
{
    class Pessoa
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public List<Pet> pets { get; private set; }
        int contadorPets = 0;

        public Pessoa(string nome, string cPF, string telefone)
        {
            Nome = nome;
            CPF = cPF;
            Telefone = telefone;
            pets = new List<Pet>();
            contadorPets = 0;
        }

        public string Acordar()
        {
            return "A pessoa acordou";
        }

        public string Alimentar(Pet pet)
        {
            return pet.Nome + " foi alimentado";
        }

        public string AdicionarPet(Pet newPet)
        {
            pets.Add(newPet);
            return "pet adicionado com sucesso";
        }

        public string removePet(Pet umPet)
        {
            string nomePet = umPet.Nome;

            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i] == umPet)
                {
                    pets.Remove(pets[i]);
                }
            }
            return nomePet + " removido com sucesso";
        }

        public string consultarPet(Pet umPet)
        {
            return "Nome: " + umPet.Nome + ". | Nascimento: " + umPet.Nascimento + ". | Peso: " + umPet.Peso + "kg. | Raça: " + umPet.Raca.GetNome() + ". ";
        }

        public string alterarPet(Pet umPet, string peso)
        {
            string nomePet = umPet.Nome;

            for (int i = 0; i < pets.Count; i++)
            {
                if (pets[i] == umPet)
                {
                    pets[i].Peso = double.Parse(peso);
                }
            }
            return "Peso de " + nomePet + " alterado para " + umPet.Peso + "kg. ";
        }
    }
}
