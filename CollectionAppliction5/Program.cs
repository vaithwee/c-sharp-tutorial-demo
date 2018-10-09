using System;
using System.Collections;

namespace CollectionAppliction5
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue q = new Queue();
             q.Enqueue('A');
             q.Enqueue('M');
             q.Enqueue('G');
             q.Enqueue('W');


             Console.WriteLine("Current queue: ");
             foreach (char c in q)
             {
                 Console.Write(c + " ");
             }

             q.Enqueue('V');
             q.Enqueue('M');
             Console.WriteLine("Current queue:");
             foreach (char c in q)
             {
                 Console.Write(c + " ");
             }
             Console.WriteLine();

             Console.WriteLine("Removing some values ");
             char ch = (char)q.Dequeue();
             Console.WriteLine("The removed value:" + ch);
             ch = (char)q.Dequeue();
             Console.WriteLine("the removed value: " + ch);
             
        }
    }
}
