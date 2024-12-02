using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correcao_Prova
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa umaPessoa = new Pessoa("Freddy", "277658741254", "32658989");

            Raca raca1 = new Raca();
            raca1.SetNome("Cocker");
            raca1.SetPorte("Médio");

            Raca raca2 = new Raca();
            raca2.SetNome("Dog Alemão");
            raca2.SetPorte("Grande");

            Raca raca3 = new Raca();
            raca3.SetNome("Beagle");
            raca3.SetPorte("Médio");

            Pet cachorro = new Pet("Meg", DateTime.Parse("01/02/2018"), 15, raca3);
            Console.WriteLine(umaPessoa.AdicionarPet(cachorro));

            Pet dog1 = new Pet("Kiko", DateTime.Parse("01/01/1980"), 15, raca1);
            Console.WriteLine(umaPessoa.AdicionarPet(dog1));

            Pet dog2 = new Pet("Xuxu", DateTime.Parse("01/01/1980"), 15, raca2);
            Console.WriteLine(umaPessoa.AdicionarPet(dog2));

            Pet dog3 = new Pet("Harry", DateTime.Parse("01/01/1980"), 15, raca3);
            Console.WriteLine(umaPessoa.AdicionarPet(dog3));

            Pet dog4 = new Pet("Suzy", DateTime.Parse("01/01/1980"), 15, raca1);
            Console.WriteLine(umaPessoa.AdicionarPet(dog4));

            Pet dog5 = new Pet("Kaka", DateTime.Parse("01/01/1980"), 15, raca3);
            Console.WriteLine(umaPessoa.AdicionarPet(dog5));

            Pet dog6 = new Pet("Bella", DateTime.Parse("01/01/1980"), 15, raca2);
            Console.WriteLine(umaPessoa.AdicionarPet(dog6));

            Pet dog7 = new Pet("Kiki", DateTime.Parse("01/01/1980"), 15, raca2);
            Console.WriteLine(umaPessoa.AdicionarPet(dog7));

            Pet dog8 = new Pet("Kah", DateTime.Parse("01/01/1980"), 15, raca1);
            Console.WriteLine(umaPessoa.AdicionarPet(dog8));

            Pet dog9 = new Pet("Mary", DateTime.Parse("01/01/1980"), 15, raca3);
            Console.WriteLine(umaPessoa.AdicionarPet(dog9));

            Pet dog10 = new Pet("Juju", DateTime.Parse("01/01/1980"), 15, raca3);
            Console.WriteLine(umaPessoa.AdicionarPet(dog10));

            Console.WriteLine();

            foreach (Pet pet in umaPessoa.pets)
            {
                Console.WriteLine("Pet: " + pet.Nome + ". ");
            }

            Console.WriteLine();
            Console.WriteLine(umaPessoa.consultarPet(dog1));

            Console.WriteLine();
            Console.WriteLine(umaPessoa.alterarPet(dog1, "20"));

            Console.WriteLine();

            Console.WriteLine(umaPessoa.removePet(dog1));
            Console.WriteLine();

            foreach (Pet pet in umaPessoa.pets)
            {
                Console.WriteLine("Pet: " + pet.Nome + ". ");
            }

            Console.WriteLine();

            Console.ReadKey();

        }
    }
}
