using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4_RedeSocial
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataPostagem = new DateTime(2022,02,22, 14, 24, 35);
            string subtit = "";
            string tit = "";

            Postagem postagem = new Postagem(dataPostagem, "Comida", "Hoje eu comi um pão");
            
            Console.WriteLine("Postagem: ");
            Console.WriteLine("Data e Hora da Postagem: " + postagem.GetSetDataHora);
            Console.WriteLine("Titulo: " + postagem.GetSetTitulo);
            Console.WriteLine("Subtitulo: " + postagem.GetSetSubtitulo);

            Console.WriteLine();
            Console.WriteLine("Digite a alteração do Título: ");
            tit = Console.ReadLine();

            postagem.GetSetTitulo = tit;
            postagem.editarTitulo(tit);

            Console.WriteLine();
            Console.WriteLine("Digite a alteração do Subtítulo: ");
            subtit = Console.ReadLine();

            postagem.GetSetSubtitulo = subtit;
            postagem.editarSubtitulo(subtit);

            Console.WriteLine();
            Console.WriteLine("Postagem: ");
            Console.WriteLine("Data e Hora da Postagem: " + postagem.GetSetDataHora);
            Console.WriteLine("Titulo: " + postagem.GetSetTitulo);
            Console.WriteLine("Subtitulo: " + postagem.GetSetSubtitulo);

            Console.WriteLine();
            Console.WriteLine("Pressione algo para excluir a Publicação: ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine(postagem.excluirPublicacao());

            Console.ReadKey();
        }
    }
}
