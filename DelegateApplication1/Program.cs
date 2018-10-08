using System;

delegate int NumberChanger(int n);
namespace DelegateApplication1
{
    class Program
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return p;
        }

        public static int MultNum(int q)
        {
            num *= q;
            return num;
        }
        public static int GetNum()
        {
            return num;
        }
        static void Main(string[] args)
        {
            NumberChanger nc1 = new NumberChanger(AddNum);
            NumberChanger nc2 = new NumberChanger(MultNum);

            nc1(25);
            Console.WriteLine("value of num : {0}", GetNum());
            nc2(5);
            Console.WriteLine("value of num : {0}", GetNum());
        }
    }
}
