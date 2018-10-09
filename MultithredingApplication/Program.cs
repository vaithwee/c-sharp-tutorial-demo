using System;
using System.Threading;

namespace MultithredingApplication
{
    class Program
    {
        public static void CallToChildThread()
        {
            Console.WriteLine("child thread starts");
        }
        static void Main(string[] args)
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            Console.WriteLine("In Main: createing the child thread");
            Thread childThread = new Thread(childref);
            childThread.Start();
        }
    }
}
