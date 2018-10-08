using System;

namespace TutorialAppliaction
{
    public abstract class Person
    {
        public abstract string Name
        {
            get;
            set;
        }

        public abstract int Age
        {
            get;
            set;
        }
    }

    class Student : Person
    {
        private string code = "n.a";
        private string name = "n.a";
        private int age = 0;
        public string Code
        {
            get
            {
                return code;
            }
            set
            {
                code = value;
            }
        }

        public override string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public override string ToString()
        {
            return "Code = " + code + ", Name = " + name + ", Age = " + age;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
           Student s = new Student();
           s.Code = "001";
           s.Name = "Zra";
           s.Age = 9;
           Console.WriteLine("Student Info : {0}", s);
        }
    }
}
