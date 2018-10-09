using System;
using System.Threading;

namespace MultithreadApplication2
{
    class Program
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("child thread starts");
            int sleepfor = 5000;
            Console.WriteLine("child thread paused for {0} seconds", sleepfor / 1000);
            Thread.Sleep(sleepfor);
            Console.WriteLine("child thread resumes");
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("in main: creating the child thread");
            Thread thread = new Thread(childref);
            thread.Start();
        }
    }
}
