using System;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Programa que soma dois numeros...");
            Console.WriteLine("Digite um número...");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro número...");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma dos números é {SomaNumeros(n1,n2)}.");
        }

        public static int SomaNumeros(int n1, int n2)
        {
            return n1 + n2;
        }
    }
}
