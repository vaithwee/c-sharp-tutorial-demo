using System;
using first_namespace;
using sceond_namespace;
namespace first_namespace
{
    class abc
    {
        public void func()
        {
            Console.WriteLine("inside first name space");
        }
    }
}

namespace sceond_namespace
{
    class efg
    {
        public void func()
        {
            Console.WriteLine("inside second name speace");
        }
    }
}

namespace NameSpace2
{
    class Program
    {
        static void Main(string[] args)
        {
           abc fc = new abc();
           efg sc = new efg();
           fc.func();
           sc.func();
        }
    }
}
