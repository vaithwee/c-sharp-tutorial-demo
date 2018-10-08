using System;

namespace IndexerApplication
{

    class IndexedNames
    {
        private string[] nameList = new string[size];
        static public int size = 10;

        public IndexedNames()
        {
            for (int idx = 0; idx < size;idx++)
            {
                nameList[idx] = "n.a";
            }
        }
        public string this[int index]
        {
            get
            {
                string tmp;
                if (index >=0 && index < size)
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
                if (index >= 0 && index < size)
                {
                    nameList[index] = value;
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IndexedNames names = new IndexedNames();
            names[0] = "Zara";
            names[1] = "Riz";
            names[2] = "Nuha";
            names[3] = "Asif";
            names[4] = "Davinder";
            names[5] = "Sunil";
            names[6] = "Rublic";

            for (int i= 0; i < IndexedNames.size; i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }
}
