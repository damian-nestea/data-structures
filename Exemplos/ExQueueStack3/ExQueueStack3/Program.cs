using System;
using System.Collections;
using System.Linq;

namespace ExQueueStack3
{
    class Program
    {
        static void Main(string[] args)
        {
            string option = "";
            Stack pilha = new Stack();

            while (option != "0")
            {
                MostraMenu();
                option = Console.ReadLine();
                if (option == "1")
                {
                    Console.WriteLine("Digite o valor a ser inserido: ");
                    string character = Console.ReadLine();
                    if (character.All(char.IsUpper))
                    {
                        Console.WriteLine("O valor inserido foi: " + character + " e vai ser inserido na pilha...");
                        pilha.Push(character);
                    }
                    else if (character.All(char.IsLower))
                    {
                        Console.WriteLine(" O valor inserido foi: " + character + " e um elemento será removido da pilha...");
                        string characterToRemove = pilha.Pop().ToString();
                        Console.WriteLine("O valor removido foi: " + characterToRemove);
                    }
                    else
                    {
                        Console.WriteLine("O valor inserido foi: " + character + " e o próximo elemento a ser removido da pilha é: " + pilha.Peek());
                    }
                }
                else if (option == "2") 
                {
                    MostraPilha(pilha);
                }
                else if (option == "0")
                {
                    Console.WriteLine("Saindo...");
                }
                else
                {
                    Console.WriteLine("Opção inválida!");
                }
            }
        }

        public static void MostraMenu()
        {
            Console.WriteLine("Digite a opção desejada: ");
            Console.WriteLine("1 - Inserir");
            Console.WriteLine("2 - Mostrar Pilha");
            Console.WriteLine("0 - Sair");
        }

        public static void MostraPilha(Stack pilha)
        {
            Console.WriteLine("Elementos da pilha: ");
            foreach (var item in pilha)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
