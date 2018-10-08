using System;
using System.IO;


namespace DelegateApplication3
{

    class PrintString
    {
        static FileStream fs;
        static StreamWriter sw;
        public delegate void printString(string s);
        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The String is {0}", str);
        }
        public static void WriteToFile(string str)
        {
            fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        public static void SendString(printString ps)
        {
            ps("Hello world");
        }

        static void Main(string[] args)
        {
            printString ps1 = new printString(WriteToScreen);
            printString ps2 = new printString(WriteToFile);
            SendString(ps1);
            SendString(ps2);
        }
    }
}
