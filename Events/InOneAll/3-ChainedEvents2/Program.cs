using System;

namespace _3_ChainedEvents2
{
    // Step 1
    // Define the delegate for the event handler
    public delegate void myEventHandler(string value);

    class MyClass
    {
        private string theVal;

        // declare the event handler defined by myself
        public event myEventHandler valueChanged;

        // declare the event handler based on the .net framework guideline
        public event EventHandler<ObjectChangeEventArgs> objChanged;

        public string Val
        {
            set
            {
                this.theVal = value;
                // when the value changes, fire the event
                this.valueChanged(theVal);
                // when the property changes, fire the event
                this.objChanged(this, new ObjectChangeEventArgs { propChanged = "Val" });
            }
        }
    }

    class ObjectChangeEventArgs : EventArgs
    {
        public string propChanged;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // create the test class
            MyClass obj = new MyClass();

            // Use a named function as an event handler
            // Connect multiple event handlers
            obj.valueChanged += changeListener1;
            obj.valueChanged += changeListener2;

            // Use an anonymous delegate as the event handler
            obj.valueChanged += delegate (string s) {
                Console.WriteLine("This came from the anonymous handler!");
            };

            obj.objChanged += delegate(object sender, ObjectChangeEventArgs e) {
                Console.WriteLine("{0} had the '{1}' property changed", sender.GetType(), e.propChanged);
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

        static void changeListener1(string value)
        {
            Console.WriteLine("The value changed to {0}", value);
        }

        static void changeListener2(string value)
        {
            Console.WriteLine("I also listen to the event, and got {0}", value);
        }
    }
}
