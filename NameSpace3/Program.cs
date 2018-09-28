using System;

namespace SomeNameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("in some name space");
            Nested.NestNameSpaceClass.SayHello();
        }
    }

    namespace Nested
    {
        public class NestNameSpaceClass
        {
            public static void SayHello()
            {
                Console.WriteLine("In Nested");
            }
        }
    }
}
