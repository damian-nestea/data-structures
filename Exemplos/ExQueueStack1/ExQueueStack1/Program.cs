using System;
using System.Collections;

namespace ExQueueStack1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue fila = new Queue();
            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);

            Console.WriteLine("Contagem: " + fila.Count);

            Console.WriteLine("Apagando 1 elemento");
            fila.Dequeue();

            if (fila.Contains(1))
            {
                Console.WriteLine("A fila contém o número 1");
            }
            else
            {
                Console.WriteLine("A fila não contém o número 1");
            }

            if (fila.Contains(5))
            {
                Console.WriteLine("A fila contém o número 5");
            }
            else
            {
                Console.WriteLine("A fila não contém o número 5");
            }

            Console.WriteLine($"O próximo elemento a ser removido é o {fila.Peek()}");
            fila.Enqueue(6);
            fila.Enqueue(7);
            fila.Enqueue(8);
            fila.Enqueue(9);
            fila.Enqueue(10);

            Console.WriteLine("FILA");
            foreach(int n in fila)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Apagando 2 elementos");
            fila.Dequeue();
            fila.Dequeue();

            Console.WriteLine("FILA");
            foreach (int n in fila)
            {
                Console.WriteLine(n);
            }

            Console.WriteLine("Limpando Fila");
            fila.Clear();
            Console.WriteLine("Contagem: " + fila.Count);
        }
    }
}
