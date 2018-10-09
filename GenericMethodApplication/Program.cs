using System;
using System.Collections.Generic;

namespace GenericMethodApplication
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        static void Main(string[] args)
        {
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'V';

            Console.WriteLine("Int values before calling swap:");
            Console.WriteLine("a = {0}, b = {0}", a, b);
            Console.WriteLine("char values before caling swap:");
            Console.WriteLine("c = {0}, d = {0}", c, d);


            Swap<int>(ref a, ref b);
            Swap<char>(ref c, ref d);

            Console.WriteLine("int values after calling swap:");
            Console.WriteLine("a = {0}, b = {0}", a, b);
            Console.WriteLine("char values after calling swap:");
            Console.WriteLine("c = {0}, d = {0}", c, d);
        }
    }
}
