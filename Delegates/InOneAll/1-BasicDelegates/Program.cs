using System;

namespace _1_BasicDelegates
{
    // Step 1
    // Declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);

    // Option 2 - Step 2
    // Instance methods of classes as delegates
    class MyClass
    {
        // Delegates can be bound to instance members as well as static class functions
        public string InstanceMethod1(int arg1, int arg2)
        {
            return ((arg1 + arg2) * arg1).ToString();
        }
    }

    class Program
    {
        // Option 1 - Step 2
        // Implement function that serves as a version of the delegate
        // This example use Static class functions to implements the delegate
        static string func1(int a, int b)
        {
            return (a + b).ToString();
        }

        static string func2(int a, int b)
        {
            return (a * b).ToString();
        }

        static void Main(string[] args)
        {
            // Option 1 - Step3
            // Create an instance of the delegate
            MyDelegate f = func1;
            Console.WriteLine("The number is: " + f(10, 20));

            f = func2;
            Console.WriteLine("The number is: " + f(10, 20));

            // Option 2 - Step3
            MyClass mc = new MyClass();
            f = mc.InstanceMethod1;
            Console.WriteLine("The number is: " + f(10, 20));

            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }        
    }
}
