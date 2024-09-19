using System;
using System.Collections;

namespace Exercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            int option = 0;
            while (option != 6)
            {
                Console.WriteLine("Programa ArrayList de Palavras");
                MostrarMenu();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InserirPalavra(ref al);
                        break;
                    case 2:
                        RemoverPalavra(ref al);
                        break;
                    case 3:
                        ListarPalavras(ref al);
                        break;
                    case 4:
                        PesquisarPalavra(ref al);
                        break;
                    case 5:
                        OrdenarPalavras(ref al);
                        break;
                    case 6:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }

        }

        public static void MostrarMenu()
        {
            Console.WriteLine("OPÇÕES");
            Console.WriteLine("1 - Inserir palavra");
            Console.WriteLine("2 - Remover palavra");
            Console.WriteLine("3 - Listar palavras");
            Console.WriteLine("4 - Pesquisar palavra");
            Console.WriteLine("5 - Ordenar palavras");
            Console.WriteLine("6 - Sair");
        }

        public static void InserirPalavra(ref ArrayList al)
        {
            Console.WriteLine("Digite uma palavra para inserir no ArrayList:");
            string palavra = Console.ReadLine();
            al.Add(palavra);
        }

        public static void RemoverPalavra(ref ArrayList al)
        {
            Console.WriteLine("Digite o índice que deseja remover:");
            int indice = int.Parse(Console.ReadLine());
            if (al.Count > 0 && indice >= 0 && indice < al.Count)
            {
                al.RemoveAt(indice);
            }
            else
            {
                Console.WriteLine("Índice inválido");
            }
        }

        public static void ListarPalavras(ref ArrayList al)
        {
            Console.WriteLine("Palavras no ArrayList:");
            foreach (string palavra in al)
            {
                Console.WriteLine("Palavra " + al.IndexOf(palavra) + " - " + palavra + ".");
            }
            Console.WriteLine();
        }

        public static void PesquisarPalavra(ref ArrayList al)
        {
            Console.WriteLine("Digite a palavra que deseja pesquisar:");
            string palavra = Console.ReadLine();
            if (al.Contains(palavra))
            {
                Console.WriteLine("Palavra encontrada no índice " + al.IndexOf(palavra));
            }
            else
            {
                Console.WriteLine("Palavra não encontrada");
            }
        }

        public static void OrdenarPalavras(ref ArrayList al)
        {
            al.Sort();
        }


    }
}