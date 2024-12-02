using System;

namespace prj35347_Lampada
{
    class Program
    {
        static void Main(string[] args)
        {
            clsLampada lampada = new clsLampada();
            string conexao = "";
            int cont = 0;
            bool status = true;

            while (true)
            {
                conexao = "";
                cont = 0;
                status = true;

                while (conexao.ToLower().Trim() != "s")
                {
                    Console.WriteLine("Nenhuma lâmpada encontrada! ");
                    Console.WriteLine("Deseja colocar uma lâmpada? s/n ");
                    conexao = Console.ReadLine().ToString();

                    if (conexao.ToLower().Trim() == "s")
                    {
                        break;
                    }

                    if (lampada.VerificarLetraS(conexao.ToLower().Trim()))
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nenhuma lâmpada encontrada! ");
                        Console.WriteLine("Deseja colocar uma lâmpada? s/n ");
                        conexao = Console.ReadLine().ToString();
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Informe apenas 's' ou 'n' ");
                        Console.WriteLine();
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Lâmpada conectada! ");
                Console.WriteLine("Pressione alguma tecla para ligar a lâmpada! ");
                Console.ReadKey();

                while (cont < 4)
                {

                    Console.WriteLine();
                    Console.WriteLine(lampada.verificarStatus(status));
                    Console.WriteLine(lampada.verificarStatus2(status));
                    Console.ReadKey();
                    status = !status;
                    cont++;
                }

                Console.WriteLine();
                Console.WriteLine("A lâmpada queimou! ");
                Console.WriteLine();
            }

            //Console.ReadKey();
        }
    }
}
