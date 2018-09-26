using System;

namespace OperatorOvlApplication
{
    class Box
    {
        private double length;
        private double breadth;
        private double height;

        public double GetVolume()
        {
            return length * breadth * height;
        }
        public void SetLength(double len)
        {
            length = len;
        }
        public void SetBreadth(double bre)
        {
            breadth = bre;
        }
        public void SetHeight(double hei)
        {
            height = hei;
        }

        public static Box operator+ (Box b, Box c)
        {
            Box box = new Box();
            box.length = b.length + c.length;
            box.breadth = c.breadth + b.breadth;
            box.height = b.height + c.height;
            return box;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();
            double volume = 0;

            box1.SetLength(6.0);
            box1.SetBreadth(7);
            box1.SetHeight(5);


            box2.SetLength(12);
            box2.SetBreadth(13);
            box2.SetHeight(10);

            volume = box1.GetVolume();
            Console.WriteLine("box1 volume is {0}", volume);
        }
    }
}
