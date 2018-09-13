using System;

namespace PolymorphismAapplication3
{
    class Shape
    {
        protected int width, height;
        public Shape(int a=0, int b=0)
        {
            width = a;
            height = b;
        }

        public virtual int Area()
        {
            Console.WriteLine("parent class area : ");
            return 0;
        }

    }
    class Rectangle : Shape 
    {
        public Rectangle(int a=0, int b=0) : base(a, b)
        {

        }
        public override int Area()
        {
            Console.WriteLine("Rectangle class area: ");
            return width * height;
        }

    }
    class Triangle : Shape
    {
        public Triangle(int a=0, int b=0) : base(a, b)
        {

        }
        public override int Area()
        {
            Console.WriteLine("Triangle class area :");
            return (width * height) / 2;
        }
    }

    class Caller 
    {
        public void CallArea(Shape sh)
        {
            int a = sh.Area();
            Console.WriteLine("area: {0}", a);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Caller c = new Caller();
            Rectangle rectangle = new Rectangle(10,7);
            Triangle triangle = new Triangle(10, 5);
            c.CallArea(rectangle);
            c.CallArea(triangle);
        }
    }
}
