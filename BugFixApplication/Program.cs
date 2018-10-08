using System;
using System.Reflection;

namespace BugFixApplication
{
    [AttributeUsage(AttributeTargets.Class |
    AttributeTargets.Constructor |
    AttributeTargets.Field |
    AttributeTargets.Field |
    AttributeTargets.Method |
    AttributeTargets.Property, AllowMultiple = true)]

    public class DebugInfo : System.Attribute
    {
        private int bugNo;
        private string developer;
        private string lastRevivew;
        public string message;

        public DebugInfo(int bg, string dev, string d)
        {
            this.bugNo = bg;
            this.developer = dev;
            this.lastRevivew = d;
        }

        public int BugNo
        {
            get
            {
                return bugNo;
            }
        }

        public string Developer
        {
            get
            {
                return developer;
            }
        }

        public string LastRevivew
        {
            get
            {
                return lastRevivew;
            }
        }
        
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
            }
        }
    }

    [DebugInfo(45, "Zara Ali", "12/8/2012", Message = "Return type mismatch")]
    [DebugInfo(49, "Nuha Ali", "10/10/2012", Message = "Unuse varialbe")]
    class Rectangle
    {
        protected double length;
        protected double width;
        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        [DebugInfo(55, "Zara Ali", "19/10/2012", Message = "Return type mismatch")]
        public double GetArea()
        {
            return length * width;
        }

        [DebugInfo(56, "Zara Ali", "19/10/2012")]
        public void Display()
        {
            Console.WriteLine("Length : {0}", length);
            Console.WriteLine("Width : {0}", width);
            Console.WriteLine("Area : {0}", GetArea());

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(4.5, 7.5);
            rectangle.Display();

            Type type = typeof(Rectangle);
            foreach (Object attritubes in type.GetCustomAttributes(false))
            {
                DebugInfo obi = (DebugInfo)attritubes;
                if (null != obi)
                {
                    Console.WriteLine("Bug No : {0}", obi.BugNo);
                    Console.WriteLine("Developer : {0}", obi.Developer);
                    Console.WriteLine("Last Reviewed : {0}", obi.LastRevivew);
                    Console.WriteLine("Remarks : {0}", obi.Message);
                }
            }

            foreach (MethodInfo m in type.GetMethods())
            {
                foreach (Attribute a in m.GetCustomAttributes(true))
                {
                    DebugInfo dbi = (DebugInfo)a;
                    if (null != dbi)
                    {
                        Console.WriteLine("Bug No : {0}", dbi.BugNo);
                        Console.WriteLine("Developer : {0}", dbi.Developer);
                        Console.WriteLine("Last Reviewed : {0}", dbi.LastRevivew);
                        Console.WriteLine("Remarks : {0}", dbi.Message);
                    }
                }
            }
        }
    }
}
