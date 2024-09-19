using System;
using System.Collections;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            int option = 0;
            while(option != 6)
            {
                MostrarMenu();
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InserirNumero(ref al);
                        break;
                    case 2:
                        RemoverNumero(ref al);
                        break;
                    case 3:
                        ListarNumeros(ref al);
                        break;
                    case 4:
                        PesquisarNumero(ref al);
                        break;
                    case 5:
                        OrdenarNumeros(ref al);
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
            Console.WriteLine("1 - Inserir um número");
            Console.WriteLine("2 - Remover um número");
            Console.WriteLine("3 - Listar os números");
            Console.WriteLine("4 - Pesquisar um número");
            Console.WriteLine("5 - Ordenar os números");
            Console.WriteLine("6 - Sair");
        }

        public static void InserirNumero(ref ArrayList al)
        {
            Console.WriteLine("Digite um número para inserir no ArrayList:");
            int numero = int.Parse(Console.ReadLine());
            al.Add(numero);
        }

        public static void RemoverNumero(ref ArrayList al)
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

        public static void ListarNumeros(ref ArrayList al)
        {
            Console.WriteLine("Números no ArrayList:");
            foreach (int numero in al)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        public static void PesquisarNumero(ref ArrayList al)
        {
            Console.WriteLine("Digite o número que deseja pesquisar:");
            int numero = int.Parse(Console.ReadLine());
            if (al.Contains(numero))
            {
                Console.WriteLine("Número encontrado no índice " + al.IndexOf(numero));
            }
            else
            {
                Console.WriteLine("Número não encontrado");
            }
        }

        public static void OrdenarNumeros(ref ArrayList al)
        {
            al.Sort();
        }


    }
}
