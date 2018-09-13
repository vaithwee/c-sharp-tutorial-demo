using System;

namespace PolymorphismApplication
{
    class Printdata 
    {
        public void Print(int i)
        {
            Console.WriteLine("Printing int : {0}", i);
        }
        public void Print(double d)
        {
            Console.WriteLine("Printing float : {0}", d);
        }
        public void Print(string s) 
        {
            Console.WriteLine("Printing string : {0}", s);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Printdata p = new Printdata();
            p.Print(5);
            p.Print(500.263);
            p.Print("Hello c#");
        }
    }
}
