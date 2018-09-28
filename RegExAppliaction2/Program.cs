using System;
using System.Text.RegularExpressions;

namespace RegExAppliaction2
{
    class Program
    {

        private static void ShowMatch(string  text, string expr)
        {
            Console.WriteLine("The Expression : " + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "make maze and manage to measure it";

            Console.WriteLine("Match word start with 'm' and ends with 'e':");
            ShowMatch(str, @"\bm\S*e\b");

        }
    }
}
