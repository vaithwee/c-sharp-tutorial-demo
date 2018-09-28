using System;
using System.Text.RegularExpressions;

namespace RegExApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Helle  world  ";
            string pattern = "\\s+";

            string replacement = " ";
            Regex rgx = new Regex(pattern);
            string result = rgx.Replace(input, replacement);
            Console.WriteLine("Original String: {0}", input);
            Console.WriteLine("Replacement String: {0}", result);
            
        }
    }
}
