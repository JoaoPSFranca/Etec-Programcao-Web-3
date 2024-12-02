using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3_Veiculo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataNascimento = new DateTime(1975, 09, 27);
            DateTime dataValidadeCNH = new DateTime(2031, 04, 29);

            Proprietario proprietario = new Proprietario();
            proprietario.SetNome("Camille Morais Jesus");
            proprietario.SetCPF("188.275.434-49");
            proprietario.SetRG("21.371.756-6");
            proprietario.SetDataNascimento(dataNascimento);
            proprietario.SetCNH(31377536423);
            proprietario.SetCNHVencimento(dataValidadeCNH);
            

            Veiculo veiculo = new Veiculo(53067843280, 2014, 2015, "Celta", proprietario);

            Console.WriteLine("Proprietário: ");
            Console.WriteLine("Nome: " + proprietario.GetNome());
            Console.WriteLine("CPF: " + proprietario.GetCPF());
            Console.WriteLine("RG: " + proprietario.GetRG());
            Console.WriteLine("Data de Nascimento: " + proprietario.GetDataNascimento());
            Console.WriteLine("CNH: " + proprietario.GetCNH());
            Console.WriteLine("Data de Validade da CNH: " + proprietario.GetCNHVencimento());

            Console.WriteLine();
            Console.WriteLine("Veíoculo: ");
            Console.WriteLine("RENAVAM: " + veiculo.GetRENAVAM());
            Console.WriteLine("Ano de Fabricação: " + veiculo.GetAnoFabricacao());
            Console.WriteLine("Ano do Modelo: " + veiculo.GetAnoModelo());
            Console.WriteLine("Nome do Modelo: " + veiculo.GetNomeModelo());
            Console.WriteLine("Nome do Proprietário: " + veiculo.GetProprietario().GetNome());


            Console.WriteLine();
            Console.WriteLine("Pressione alguma tecla para ligar o veículo ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(veiculo.LigarDesligar());

            Console.WriteLine();
            Console.WriteLine("Pressione alguma tecla para acelerar o veículo ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(veiculo.Acelerar());

            Console.WriteLine();
            Console.WriteLine("Pressione alguma tecla para frear o veículo ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(veiculo.Frear());

            Console.WriteLine();
            Console.WriteLine("Pressione alguma tecla para desligar o veículo ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(veiculo.LigarDesligar());
            Console.ReadKey();

            Console.WriteLine();

            DateTime dataNascimento2 = new DateTime(1998, 07, 07);
            DateTime dataValidadeCNH2 = new DateTime(2032, 10, 18);

            Proprietario proprietario2 = new Proprietario("Frank Espindola Leonicios", "012.443.625-06", "24.697.777-2", dataNascimento2, 98387737581, dataValidadeCNH2);

            Veiculo veiculo2 = new Veiculo(83758809754, 2016, 2016, "Versa", proprietario2);

            Console.WriteLine("Proprietário: ");
            Console.WriteLine("Nome: " + proprietario2.GetNome());
            Console.WriteLine("CPF: " + proprietario2.GetCPF());
            Console.WriteLine("RG: " + proprietario2.GetRG());
            Console.WriteLine("Data de Nascimento: " + proprietario2.GetDataNascimento());
            Console.WriteLine("CNH: " + proprietario2.GetCNH());
            Console.WriteLine("Data de Validade da CNH: " + proprietario2.GetCNHVencimento());

            Console.WriteLine();
            Console.WriteLine("Veíoculo: ");
            Console.WriteLine("RENAVAM: " + veiculo2.GetRENAVAM());
            Console.WriteLine("Ano de Fabricação: " + veiculo2.GetAnoFabricacao());
            Console.WriteLine("Ano do Modelo: " + veiculo2.GetAnoModelo());
            Console.WriteLine("Nome do Modelo: " + veiculo2.GetNomeModelo());
            Console.WriteLine("Nome do Proprietário: " + veiculo2.GetProprietario().GetNome());


            Console.WriteLine();
            Console.WriteLine("Pressione alguma tecla para ligar o segundo veículo ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(veiculo2.LigarDesligar());

            Console.WriteLine();
            Console.WriteLine("Pressione alguma tecla para acelerar o veículo ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(veiculo2.Acelerar());

            Console.WriteLine();
            Console.WriteLine("Pressione alguma tecla para frear o veículo ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(veiculo2.Frear());

            Console.WriteLine();
            Console.WriteLine("Pressione alguma tecla para desligar o veículo ");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine(veiculo2.LigarDesligar());
            Console.ReadKey();
        }
    }
}
