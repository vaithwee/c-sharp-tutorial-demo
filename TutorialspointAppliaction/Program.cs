using System;

namespace TutorialspointAppliaction
{
    class Student
    {
        private string code = "n.a";
        private string name = "not known";
        private int age = 0;

        public string Code
        {
            set
            {
                code = value;
            }
            get
            {
                return code;
            }
        }

        public string Name
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

        public int Age
        {
            set
            {
                age = value;
            }
            get
            {
                return age;
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
           s.Name = "Zara";
           s.Age = 9;

           Console.WriteLine("Student Info : {0}", s);
           s.Age += 1;
           Console.WriteLine("Student Info : {0}", s);
        }
    }
}
