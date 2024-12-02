using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2_LivroAutorEditora
{
    class Livro
    {
        public string Nome { get; set; }
        public DateTime AnoPublicacao { get; set; }
        public string CodigoISBN { get; set; }
        public int QtdPaginas { get; set; }
        public Autor Autor { get; set; }
        public Editora Editora { get; set; }
        private int contador = 1;

        public Livro(string nome, DateTime anoPublicacao, string codigoISBN, int qtdPaginas, Autor autor, Editora editora)
        {
            this.Nome = nome;
            this.AnoPublicacao = anoPublicacao;
            this.CodigoISBN = codigoISBN;
            this.QtdPaginas = qtdPaginas;
            this.Autor = autor;
            this.Editora = editora;
        }

        public string AbrirLivro()
        {
            return "Livro Aberto!";
        }

        public string Perguntar()
        {
            if (contador >= QtdPaginas)
                return "Aperte 'v' para voltar a página. ";
            else
                return "Aperte 'p' para passar a página ou aperte 'v' para voltar a página. ";
        }

        public string PassarPagina(string resposta)
        {
            if (contador > 1 && resposta.ToLower() == "v")
            {
                contador--;
                return "Voltou para a página " + contador.ToString();
            }
            else
            {
                if (contador < QtdPaginas && resposta.ToLower() == "p")
                {
                    contador++;
                    return "Passou para a página " + contador.ToString();
                }
                else
                    return "Falha ao passar a página";
            }

        }
    }
}
