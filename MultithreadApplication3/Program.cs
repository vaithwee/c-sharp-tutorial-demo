using System;
using System.Threading;

namespace MultithreadApplication3
{
    class Program
    {
        public static void CallToChildThread()
        {
            try
            {
                Console.WriteLine("child thread start");

                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }

                Console.WriteLine("child thread completed");
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine("thread abort exception");
            }
            finally
            {
                Console.WriteLine("couldn't cathc the thread execption");
            }
        }
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(CallToChildThread);
            Console.WriteLine("in main: creating the child thread");
            Thread thread = new Thread(ts);
            thread.Start();
            Thread.Sleep(2000);
            Console.WriteLine("in main: aborting the child thread");
            thread.Abort();
            Console.ReadKey();
        }
    }
}
