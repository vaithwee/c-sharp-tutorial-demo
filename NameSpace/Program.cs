using System;

namespace first_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("inside first_space");
        }
    }
}

namespace second_space
{
    class namespace_cl
    {
        public void func()
        {
            Console.WriteLine("inside second_space");
        }
    }
}

namespace NameSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            first_space.namespace_cl fc = new first_space.namespace_cl();
            second_space.namespace_cl sc = new second_space.namespace_cl();

            fc.func();
            sc.func();
        }
    }
}
