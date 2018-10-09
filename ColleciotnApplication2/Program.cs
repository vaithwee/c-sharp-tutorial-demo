using System;
using System.Collections;

namespace ColleciotnApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add("001", "Zara Ali");
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "John Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");

            if (ht.ContainsValue("Nuha Ali"))
            {
                Console.WriteLine("Nuha Ali");
            }
            else
            {
                ht.Add("008", "Nuha Ali");
            }

            ICollection keys = ht.Keys;
            foreach (string key in keys)
            {
                Console.WriteLine(key + " : " + ht[key]);
            }
        }
    }
}
