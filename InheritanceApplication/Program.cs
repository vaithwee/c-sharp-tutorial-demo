using System;

namespace InheritanceApplication
{
    class Shape
    {
        protected int width;
        protected int height;

        public void SetWidth(int w)
        {
            width = w;
        }
        public void SetHeight(int h)
        {
            height = h;
        }

    }

    public interface PainCost
    {
        int GetCost(int area);
    }

    class Rectangle : Shape, PainCost
    {
        public int GetArea()
        {
            return (width * height);
        }
        public int GetCost(int area)        
        {
            return area * 70;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            int area;
            rect.SetHeight(5);
            rect.SetWidth(7);
            area = rect.GetArea();
            Console.WriteLine("area is {0}", rect.GetArea());

            Console.WriteLine("cost is {0}", rect.GetCost(area));

        }
    }
}
