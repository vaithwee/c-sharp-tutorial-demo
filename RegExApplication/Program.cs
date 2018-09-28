using System;
using System.Text.RegularExpressions;

namespace RegExApplication
{
    class Program
    {

        private static void ShowMatch(string text, string expr)
        {
            Console.WriteLine("The Expression:" + expr);
            MatchCollection mc = Regex.Matches(text, expr);
            foreach (Match m in mc)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            string str = "A Thousand Splendid Suns";
            Console.WriteLine("Matching words that start with 's'");
            ShowMatch(str, @"\bS\S*");

        }
    }
}
