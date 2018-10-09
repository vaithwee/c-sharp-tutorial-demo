using System;
using System.Threading;

namespace MultithreadingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread th = Thread.CurrentThread;
            th.Name = "MainThread";
            Console.WriteLine("this is {0}", th.Name);
        }
    }
}
