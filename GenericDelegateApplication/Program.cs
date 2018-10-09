using System;
using System.Collections.Generic;

delegate T NumberChanger<T>(T n);

namespace GenericDelegateApplication
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
            NumberChanger<int> nc = new NumberChanger<int>(AddNum);
            NumberChanger<int> nc2 = new NumberChanger<int>(MultNum);

            nc(25);

            Console.WriteLine("value of num: {0}", GetNum());

            nc2(5);

            Console.WriteLine("value of num: {0}", GetNum());


        }
    }
}
