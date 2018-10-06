using System;

namespace ObsoleteApplication
{
    class Program
    {
        [Obsolete("Don't use OldMethod, use NewMethod instead", true)]
        static void OldMethod()
        {
            Console.WriteLine("It is the old method");
        }
        static void NewMethod()
        {
            Console.WriteLine("It is the new method");
        }
        static void Main(string[] args)
        {
            OldMethod();
        }
    }
}
