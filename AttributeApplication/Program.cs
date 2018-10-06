#define DEBUG

using System;
using System.Diagnostics;


namespace AttributeApplication
{
    public class Myclass
    {
        [Conditional("DEBUG")]
        public static void Message(string msg)
        {
            Console.WriteLine(msg);
        }
    }
    class Program
    {
        static void function1()
        {
            Myclass.Message("In Function 1.");
            function2();
        }

        static void function2()
        {
            Myclass.Message("In Function 2");
        }
        static void Main(string[] args)
        {
            Myclass.Message("In Main Function");
            function1();
        }
    }
}
