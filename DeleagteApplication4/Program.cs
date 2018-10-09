using System;

delegate void NumberChanger(int n);
namespace DeleagteApplication4
{
    class Program
    {
        static int num = 10;

        public static void AddNum(int p)
        {
            num += p;
            Console.WriteLine("Named method: {0}", num);
        }

        public static void MultNum(int q)
        {
            num *= q;
            Console.WriteLine("named method: {0}", num);
        }
        static void Main(string[] args)
        {
            NumberChanger nc = delegate(int x)
            {
                Console.WriteLine("anonymous method: {0}", x);
            };

            nc(10);

            nc = new NumberChanger(AddNum);
            nc(5);

            nc = new NumberChanger(MultNum);
            nc(2);
        }
    }
}
