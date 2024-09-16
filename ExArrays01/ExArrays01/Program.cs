using System;

namespace ExArrays01
{
    class Program
    {
        static void Main(string[] args)
        {
            int Alunos;
            string[] Nomes;
            int[] Notas;
            Console.WriteLine("PROGRAMA NOTAS DE ALUNOS");
            Console.WriteLine("Digite a quantidade de alunos...");
            Alunos = int.Parse(Console.ReadLine());
            Nomes = new string[Alunos];
            Notas = new int[Alunos];

            Console.WriteLine("Digite os nomes e notas dos alunos...");
            for(int i = 0; i < Nomes.Length; i++)
            {
                Console.Write("Digite o nome...");
                Nomes[i] = Console.ReadLine();
                Console.Write("Digite a nota desse aluno...");
                Notas[i] = int.Parse(Console.ReadLine());
            }

            double Media = MediaNotas(Notas);
            Console.WriteLine("Alunos acima da média...");
            Console.WriteLine($"Média: {Media}");
            for(int i = 0; i < Nomes.Length; i++)
            {
                if( Notas[i] > Media)
                {
                    Console.WriteLine($"Nome: {Nomes[i]} - Nota: {Notas[i]}");
                }
            }

        }

        public static double MediaNotas(int[] Notas)
        {
            double Media; 
            double Soma = 0.0;
            for (int i = 0; i < Notas.Length; i++) 
            {
                Soma = Soma + Notas[i];
            }

            Media = Soma / Notas.Length;

            return Media;
        }
    }
}
