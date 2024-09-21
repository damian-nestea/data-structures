using System;
using System.Collections;

namespace Exercicio01
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            Queue queueCopia = new Queue();
            ArrayList al = new ArrayList();
            for (int i = 0; i < 10; i++)
            {
                queue.Enqueue(i);
            }

            MostrarQueue(queue);

            Console.WriteLine("Copiando Queue para ArrayList...");
            al = CopyQueueToArrayList(queue);
            MostrarArrayList(al);

            Console.WriteLine("Copiando Queue para QueueCopia...");
            queueCopia = CopyQueue(queue);
            Console.WriteLine("QueueCopia...");
            MostrarQueue(queueCopia);
        }

        public static void MostrarArrayList(ArrayList al)
        {
            Console.WriteLine("ARRAYLIST...");
            foreach (object ob in al)
            {
                Console.WriteLine(ob);
            }
        }

        public static void MostrarQueue(Queue queue)
        {
            Console.WriteLine("QUEUE...");
            foreach (object ob in queue)
            {
                Console.WriteLine(ob);
            }
        }

        public static ArrayList CopyQueueToArrayList(Queue queue)
        {
            ArrayList al = new ArrayList();

            foreach(object ob in queue)
            {
                al.Add(ob);
            }

            return al;
        }

        public static Queue CopyQueue(Queue queue)
        {
            Queue q = new Queue();

            foreach(object ob in queue)
            {
                q.Enqueue(ob);
            }
            return q;
        }
    }
}
