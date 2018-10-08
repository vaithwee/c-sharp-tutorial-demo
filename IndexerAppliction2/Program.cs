using System;

namespace IndexerAppliction2
{
    public class IndexedNames
    {
        public static int size = 10;
        private string[] nameList = new string[size];
        public IndexedNames()
        {
            for (int i=0;i<size;i++)
            {
                nameList[i] = "n.a";
            }
        }

        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >= 0 && index < size)
                {
                    tmp = nameList[index];
                }
                else
                {
                    tmp = "";
                }
                return tmp;
            }

            set
            {
                if (index >=0 && index < size)
                {
                    nameList[index] = value;
                }
            }
        }

        public int this[string name]
        {
            get
            {
                int index = 0;
                while (index < size)
                {
                    if (nameList[index] == name)
                    {
                        return index;
                    }
                    index++;
                }
                return index;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] =  "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Daviner";
            names[5] = "Sunil";
            names[6] = "Rubic";
            for (int i = 0; i < IndexedNames.size; ++i)
            {
                Console.WriteLine(names[i]);
            }

            Console.WriteLine(names["Nuha"]);
        }
    }
}
