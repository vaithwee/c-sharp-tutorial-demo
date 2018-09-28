using System;

namespace OperatorOvlApplication2
{
    class Box
    {
        private double lenght;
        private double breadth;
        private double height;

        public double GetVolume()
        {
            return lenght * breadth * height;
        }
        public void SetLength(double len)
        {
            lenght = len;
        }

        public void SetBreadth(double brea)
        {
            breadth = brea;
        }
        public void SetHeight(double heig)
        {
            height = heig;
        }

        public static Box operator+ (Box box1, Box box2)
        {
            Box box = new Box();
            box.lenght = box1.lenght + box2.lenght;
            box.breadth = box1.breadth + box2.breadth;
            box.height = box1.height + box2.height;
            return box;
        }

        public static bool operator== (Box box1, Box box2)
        {
            if (box1.lenght == box2.lenght && box1.breadth == box2.breadth && box1.height == box2.height)
            {
                return true;
            }
            return false;
        }

        public static bool operator!= (Box box1, Box box2)
        {
            if (box1.lenght != box2.lenght || box1.breadth != box2.breadth || box1.height != box2.height)
            {
                return true;
            }
            return false;
        }

        public static bool operator< (Box box1, Box box2)
        {
            if (box1.lenght < box2.lenght && box1.breadth < box2.breadth && box1.height < box2.height)
            {
                return true;
            }
            return false;
        }
        public static bool operator> (Box box1, Box box2)
        {
            if (box1.lenght > box2.lenght && box1.breadth > box2.breadth && box1.height > box2.height)
            {
                return true;
            }
            return false;
        }

        public static bool operator>= (Box box1, Box box2)
        {
            if (box1.lenght >= box2.lenght && box1.breadth >= box2.breadth && box1.height >= box2.height)
            {
                return true;
            }
            return false;
        }

        public static bool operator<= (Box box1, Box box2)
        {
            if (box1.lenght <= box2.lenght && box1.breadth <= box2.breadth && box1.height <= box2.height)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("{0}, {1}, {2}", lenght, breadth, height);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Box box1 = new Box();
            Box box2 = new Box();
            Box box3 = new Box();
            Box box4 = new Box();

            double volume = 0;
            
            box1.SetLength(6);
            box1.SetBreadth(7);
            box1.SetHeight(5);

            box2.SetLength(12);
            box2.SetBreadth(13);
            box2.SetHeight(10);


            Console.WriteLine("Box1: {0}", box1.ToString());
            Console.WriteLine("Box2: {0}", box2.ToString());

            volume = box1.GetVolume();
            Console.WriteLine("Box1 volume: {0}", volume);

            volume = box2.GetVolume();
            Console.WriteLine("Box2 volume: {0}", volume);


            box3 = box1 + box2;
            Console.WriteLine("Box3: {0}", box3.ToString());

            volume = box3.GetVolume();
            Console.WriteLine("Box3 volume: {0}", volume);

            if (box1 > box2)
            {
                Console.WriteLine("box1 大于 box2");
            }
            else 
            {
                Console.WriteLine("box1 不大于 box2");
            }

            if (box1 < box2)
            {
                Console.WriteLine("box1 小于 box2");
            }
            else 
            {
                Console.WriteLine("box1 不小于 box2");
            }

            if (box1 >= box2)
            {
                Console.WriteLine("box1 大于等于 box2");
            }
            else
            {
                Console.WriteLine("box1 不大于等于 box2");
            }

            if (box1 <= box2)
            {
                Console.WriteLine("box1 小于等于 box2");
            }
            else 
            {
                Console.WriteLine("box1 不小于等于 box2");
            }

            if (box1 != box2)
            {
                Console.WriteLine("box1 不等于 box2");
            }
            else 
            {
                Console.WriteLine("box1 等于 box2");
            }

            box4 = box3;
            if (box3 == box4)
            {
                Console.WriteLine("box3 等于 box4");
            }
            else
            {
                Console.WriteLine("box3 不等于 box4");
            }
        }
    }
}
