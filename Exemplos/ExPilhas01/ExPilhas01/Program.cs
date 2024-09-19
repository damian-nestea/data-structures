using System;

namespace ExPilhas01
{
    class Program
    {
        static void Main(string[] args)
        {
            int tamanhoPilha;
            int[] pilha;
            int contador = 0;
            int n1;
            Console.WriteLine("Digite o tamanho da pilha...");
            tamanhoPilha = int.Parse(Console.ReadLine());
            pilha = new int[tamanhoPilha];
            Console.WriteLine("Insira um número na pilha...");
            n1 = int.Parse(Console.ReadLine());
            AddNumPilha(ref pilha, n1, ref contador);
            Console.WriteLine("Insira um número na pilha...");
            n1 = int.Parse(Console.ReadLine());
            AddNumPilha(ref pilha, n1, ref contador);
            Console.WriteLine("Insira um número na pilha...");
            n1 = int.Parse(Console.ReadLine());
            AddNumPilha(ref pilha, n1, ref contador);
            
            MostrarPilha(pilha, contador);

            RemoveNumPilha(ref pilha, ref contador);
            MostrarPilha(pilha, contador);

        }
        public static void AddNumPilha(ref int[] pilha, int num, ref int indice)
        {
            pilha[indice] = num;
            indice++;
        }

        public static void RemoveNumPilha(ref int[] pilha, ref int indice)
        {
            pilha[indice-1] = 0;
            indice--;
        }

        public static void MostrarPilha(int[] pilha, int indice)
        {
            Console.WriteLine("PILHA");
            for(int i = 0; i < pilha.Length; i++)
            {
                Console.Write(pilha[i] + " ");
            }

            Console.WriteLine($"Indice:{indice}");
        }
    }
}
