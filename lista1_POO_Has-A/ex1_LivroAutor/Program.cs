using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1_LivroAutor
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";

            DateTime data = new DateTime(1994, 03, 17);
            DateTime data2 = new DateTime(2012, 09, 08); 

            Autor autor = new Autor("681.065.123-39", "Thamirys Vilar Donato", data);
            Livro livro = new Livro("The Killer", data2, "978-857-334-0400-5", 5, autor);

            Console.WriteLine("Livro: ");
            Console.WriteLine("Nome: " + livro.Nome.ToString());
            Console.WriteLine("Data da Publicação: " + livro.AnoPublicacao.ToString());
            Console.WriteLine("Código ISBN: " + livro.CodigoISBN.ToString());
            Console.WriteLine("Quantidade de páginas: " + livro.QtdPaginas.ToString());
            Console.WriteLine("Nome do Autor: " + livro.Autor.Nome.ToString());

            Console.WriteLine();

            Console.WriteLine("Autor: ");
            Console.WriteLine("Nome: " + autor.Nome.ToString());
            Console.WriteLine("CPF: " + autor.CPF.ToString());
            Console.WriteLine("Data de Nascimento: " + autor.DataNascimento.ToString());

            Console.WriteLine();

            Console.WriteLine("Deseja abrir o livro? ");
            Console.ReadKey();

            Console.WriteLine();

            Console.WriteLine(livro.AbrirLivro());

            while (true)
            {
                Console.WriteLine();

                Console.WriteLine("Deseja passar para a próxima página ou voltar? ");
                Console.WriteLine(livro.Perguntar());
                resposta = Console.ReadLine().ToString();

                Console.WriteLine();

                Console.WriteLine(livro.PassarPagina(resposta));

            }
        }
    }
}
