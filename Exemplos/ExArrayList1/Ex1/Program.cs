using System;
using System.Collections;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int qtdeObjetos = 0;
            ArrayList alNumeros = new ArrayList();
            Console.WriteLine($"Capacidade Inicial: {alNumeros.Capacity}");
            Console.WriteLine("Quantos objetos quer adicionar ao ArrayList?");
            qtdeObjetos = int.Parse(Console.ReadLine() );

            int n;
            for(int i = 0; i < qtdeObjetos; i++)
            {
                Console.WriteLine("Digite o objeto que deseja inserir...");
                n = int.Parse(Console.ReadLine());
                alNumeros.Add(n);
            }
            Console.WriteLine($"Contagem: {alNumeros.Count}");
            Console.WriteLine($"Capacidade: {alNumeros.Capacity}");
            alNumeros.Sort();
            Mostrar(alNumeros);
            alNumeros.Reverse();
            Mostrar(alNumeros);
            alNumeros.RemoveRange(1, 2);
            Mostrar(alNumeros);
            Console.WriteLine($"Contagem: {alNumeros.Count}");
            Console.WriteLine($"Capacidade: {alNumeros.Capacity}");
        }

        public static void Mostrar(ArrayList al)
        {
            Console.WriteLine("ARRAYLIST");
            foreach (int i in al)
            {
                Console.Write(i + " ");
            }
        }
    }
}
