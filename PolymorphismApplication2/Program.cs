using System;

namespace PolymorphismApplication2
{
    abstract class Shape 
    {
        public abstract int Area();
    }
    class Rectangle : Shape 
    {
        private int length;
        private int width;
        public Rectangle(int a=0, int b=0)
        {
            length = a;
            width = b;
        }

        public override int Area()
        {
            Console.WriteLine("reactangle area");
            return width * length;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 9);
            double area = rect.Area();
            Console.WriteLine("area : {0}", area);
        }
    }
}
