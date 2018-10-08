using System;

namespace EventApplication
{
    using System;
    public class EventTest
    {
        private int value;
        public delegate void NumManipulationHandler();
        public event NumManipulationHandler ChangedNum;
        protected virtual void OnNumberChanged()
        {
            if (ChangedNum != null)
            {
                ChangedNum();
            }
            else
            {
                Console.WriteLine("event not fire");
               
            }
        }

        public EventTest()
        {
            int n = 5;
            SetValue(n);
        }

        public void SetValue(int n)
        {
            if (value != n)
            {
                value = n;
                OnNumberChanged();
            }
        }
    }

    public class SubscribEvent
    {
        public void printf()
        {
            Console.WriteLine("event fire");
        }
    }

    public class MainClass
    {
        public static void Main()
        {
            EventTest eventTest = new EventTest();
            SubscribEvent subscribEvent = new SubscribEvent();
            eventTest.ChangedNum += new EventTest.NumManipulationHandler(subscribEvent.printf);
            eventTest.SetValue(7);
            eventTest.SetValue(11);
        }
    }

    
}
