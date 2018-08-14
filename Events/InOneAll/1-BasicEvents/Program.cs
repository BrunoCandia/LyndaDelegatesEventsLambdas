using System;

namespace _1_BasicEvents
{
    class Program
    {
        // Step 1
        // Declares the delegate for the event handler
        public delegate void myEventHandler(string value);

        // Step 2
        // Broadcast some message whenever its private string member variable changes
        class EventPublisher
        {
            private string theVal;

            // Declare the event
            public event myEventHandler valueChanged;

            public string Val
            {
                set
                {
                    this.theVal = value;
                    // when the value changes, fire the event
                    this.valueChanged(theVal);
                }
            }
        }

        static void Main(string[] args)
        {
            // Option 1 - Step 4
            // Use a named function as an event handler
            //EventPublisher obj = new EventPublisher();
            //obj.valueChanged += new myEventHandler(obj_valueChanged);

            // Option 2
            // Use an anonymous delegate as an event handler
            EventPublisher obj = new EventPublisher();
            obj.valueChanged += delegate (string val) {
                Console.WriteLine("The value changed to {0}", val);
            };

            string str;
            do
            {
                Console.WriteLine("Enter a value: ");
                str = Console.ReadLine();
                if (!str.Equals("exit"))
                {
                    obj.Val = str;
                }
            } while (!str.Equals("exit"));

            Console.WriteLine("Goodbye!");
        }

        // Option 1 - Step 3
        // Declare the function that serves as the event handler and it matches the delegate declaretion
        static void obj_valueChanged(string value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }
    }
}
