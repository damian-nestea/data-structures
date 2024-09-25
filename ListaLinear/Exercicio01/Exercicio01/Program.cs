using System;
using System.Collections.Generic;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista l1 = new Lista();
            
            l1.InserirInicio(1);
            l1.InserirInicio(2);
            l1.InserirInicio(3);
            l1.InserirFinal(4);
            l1.InserirFinal(5);
            l1.InserirFinal(6);
            l1.Inserir(1, 7);
            l1.Inserir(3, 8);
            l1.InserirInicio(9);
            l1.InserirInicio(10);

            Console.WriteLine(l1.MostraLista());

            l1.RemoverFinal();
            l1.RemoverInicio();
            l1.Remover(4);
            Console.WriteLine(l1.MostraLista());
        }
    }

    class Lista
    {
        private int _contador = 0;
        private List<int> _lista;

        public Lista()
        {
            _lista = new List<int>(10);
        }

        public Lista(int capacidade)
        {
            _lista = new List<int>(capacidade);
        }

        public void InserirInicio(int valor) 
        { 
            if(_contador >= _lista.Capacity)
            {
                Console.WriteLine(valor + " não inserido! Lista cheia!");
            }
            else
            {
                _lista.Insert(0, valor);
                _contador++;
            }
        }

        public void InserirFinal(int valor)
        {
            if(_contador >= _lista.Capacity)
            {
                Console.WriteLine(valor + " não inserido! Lista cheia!");
            }
            else
            {
                _lista.Add(valor);
                _contador++;
            }
        }

        public void Inserir(int posicao, int valor)
        {
            if (_contador >= _lista.Capacity)
            {
                Console.WriteLine(valor + " não inserido! Lista cheia!");
            }
            else
            {
                _lista.Insert(posicao,valor);
                _contador++;
            }
        }

        public void RemoverInicio()
        {
            if (_contador == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                _lista.RemoveAt(0);
                _contador--;
            }
        }

        public void RemoverFinal()
        {
            if(_contador == 0)
            {
                Console.WriteLine("ListaVazia!");
            }
            else
            {
                _lista.RemoveAt(_contador - 1);
                _contador--;
            }
        }

        public void Remover(int posicao)
        {
            if(_contador == 0)
            {
                Console.WriteLine("Lista Vazia!");
            }
            else
            {
                _lista.RemoveAt(posicao);
                _contador--;
            }
        }

        public string MostraLista()
        {
            string lista = "[";
            if (_lista.Count == 0)
            {
                return "Lista Vazia!";
            }
            else
            {
                foreach(int valor in _lista)
                {
                    lista += valor + " ";
                }
                lista += "]";
            }
            return lista;
        }
    }
}
