using System;
using System.Collections;

namespace CollectionAppliction1
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al =  new ArrayList();
            Console.WriteLine("Add some numbers:");

            al.Add(45);
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);


            Console.WriteLine("Capacity : {0}", al.Capacity);
            Console.WriteLine("Count : {0}", al.Count);

            Console.WriteLine("Content: ");
            foreach (int i in al)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Sort Content:");
            al.Sort();
            foreach (int i in al)
            {
                Console.WriteLine(i + " ");
            }
        }
    }
}
