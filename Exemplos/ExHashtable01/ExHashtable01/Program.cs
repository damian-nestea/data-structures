using System;
using System.Collections;

namespace ExHashtable01
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            for(int i = 1; i <= 5; i++)
            {
                ht.Add(i, i * 10);
            }

            MostrarHashtable(ht);
            Console.WriteLine($"Contagem: {MostraContagemHashtable(ht)}");

            Console.WriteLine("Removendo o elemento com chave 1.");
            ht.Remove(1);

            if (ht.ContainsKey(1))
            {
                Console.WriteLine("Hashtable contém o elemento com chave 1.");
            }
            else
            {
                Console.WriteLine("Hashtable não contém o elemento com chave 1.");
            }

            if (ht.ContainsKey(5))
            {
                Console.WriteLine("Hashtable contém o elemento com chave 5.");
            }
            else
            {
                Console.WriteLine("Hashtable não contém o elemento com chave 5.");
            }

            for(int i = 6; i <= 10; i++)
            {
                ht.Add(i, i * 10);
            }   

            MostrarHashtable(ht);

            Console.WriteLine("Removendo os elementos com chave 5 e 8");
            ht.Remove(5);
            ht.Remove(8);

            MostrarHashtable(ht);

            Console.WriteLine("Removendo todos os elementos com o método clear()");
            ht.Clear();

            MostrarHashtable(ht);
            Console.WriteLine("Quantidade de elementos: " + ht.Count);

        }

        public static void MostrarHashtable(Hashtable ht)
        {
            Console.WriteLine("HASHTABLE");
            foreach(DictionaryEntry de in ht)
            {
                Console.WriteLine($"Chave: {de.Key}. Valor: {de.Value}.");
            }
        }

        public static int MostraContagemHashtable(Hashtable ht)
        {
            return ht.Count;
        }
    }
}
