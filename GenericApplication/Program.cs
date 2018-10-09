using System;
using System.Collections.Generic;
namespace GenericApplication
{
    public class MyGenericArray<T>
    {
        private T[] array;
        public MyGenericArray(int size)
        {
            array = new T[size + 1];
        }

        public T GetItem(int index)
        {
            return array[index];
        }

        public void SetItem(int index, T value)
        {
            array[index] = value;
        }
    }


    class Test
    {
        static void Main(string[] args)
        {
            MyGenericArray<int> intArr = new MyGenericArray<int>(5);
            for (int c = 0; c < 5; c++)
            {
                intArr.SetItem(c, c*5);
            }

            for (int c = 0;c < 5; c++)
            {
                Console.WriteLine(intArr.GetItem(c));
            }

            Console.WriteLine();

            MyGenericArray<char> charArr = new MyGenericArray<char>(5);
            for (int c = 0; c < 5; c++)
            {
                charArr.SetItem(c, (char)(c+97));
            }

            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine(charArr.GetItem(c) + " ");
            }
        }
    }
}
