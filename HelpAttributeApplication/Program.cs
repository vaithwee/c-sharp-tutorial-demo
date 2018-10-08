using System;

namespace HelpAttributeApplication
{
    [AttributeUsage(AttributeTargets.All)]
    public class HelpAttribute : System.Attribute
    {
        public readonly string Url;
        private string topic;

        public string Topic
        {
            get
            {
                return topic;
            }

            set
            {
                topic = value;
            }
        }

        public HelpAttribute(string url)
        {
            this.Url = url;
        }
    }

    [HelpAttribute("Infomation on the class MyClass")]
    class MyClass
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            System.Reflection.MemberInfo info = typeof(MyClass);
            object[] attritubes = info.GetCustomAttributes(true);
            for (int idx = 0; idx < attritubes.Length; ++idx)
            {
                Console.WriteLine(attritubes[idx]);
            }
        }
    }
}
