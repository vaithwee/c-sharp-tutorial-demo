using System;
using System.IO;

namespace FileIOApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fileStream = new FileStream("test.data", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            for (int idx = 0; idx <= 20; idx++)
            {
                fileStream.WriteByte((byte)idx);
            }

            fileStream.Position = 0;

            for (int idx = 0;idx <= 20; ++idx)
            {
                Console.WriteLine(fileStream.ReadByte() + " ");
            }

            fileStream.Close();
            
        }
    }
}
