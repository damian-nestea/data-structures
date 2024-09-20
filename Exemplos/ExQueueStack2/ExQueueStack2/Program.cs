using System;
using System.Collections;

namespace ExQueueStack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack pilha = new Stack();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);

            Console.WriteLine("Contagem: " + pilha.Count);

            Console.WriteLine("Apagando 1 elemento");
            pilha.Pop();

            if (pilha.Contains(1))
            {
                Console.WriteLine("A pilha contém o número 1");
            }
            else
            {
                Console.WriteLine("A pilha não contém o número 1");
            }

            if (pilha.Contains(5))
            {
                Console.WriteLine("A pilha contém o número 5");
            }
            else
            {
                Console.WriteLine("A pilha não contém o número 5");
            }

            Console.WriteLine($"O próximo elemento a ser removido é o {pilha.Peek()}");
            pilha.Push(6);
            pilha.Push(7);
            pilha.Push(8);
            pilha.Push(9);
            pilha.Push(10);

            Console.WriteLine("PILHA");
            foreach (int n in pilha)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Apagando 2 elementos");
            pilha.Pop();
            pilha.Pop();

            Console.WriteLine("PILHA");
            foreach (int n in pilha)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Limpando Pilha");
            pilha.Clear();
            Console.WriteLine("Contagem: " + pilha.Count);
        }
    }
}
