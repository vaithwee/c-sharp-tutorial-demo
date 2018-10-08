using System;

delegate int NumberChnager(int num);
namespace DelegateApplication2
{
    class Program
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultNum(int q)
        {
             num *= q;
             return q;
        }

        public static int GetNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChnager nc = null;
            NumberChnager nc1 = new NumberChnager(AddNum);
            NumberChnager nc2 = new NumberChnager(MultNum);
            nc += nc1;
            nc += nc2;
            nc(5);
            Console.WriteLine("value of number : {0}", GetNum());
        }
    }
}
