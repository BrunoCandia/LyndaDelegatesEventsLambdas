using System;

namespace _3_ComposableDelegates
{
    // Step 1
    // Declare the delegate type
    public delegate void MyDelegate(int arg1, int arg2);

    class Program
    {
        // Step 2
        // Implement function that serves as a version of the delegate
        static void func1(int arg1, int arg2)
        {
            string result = (arg1 + arg2).ToString();
            Console.WriteLine("The number is: " + result);
        }

        static void func2(int arg1, int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine("The number is: " + result);
        }

        static void Main(string[] args)
        {
            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            MyDelegate f1f2 = f1 + f2;

            // Call each delegate and then the chain
            Console.WriteLine("Calling first delegate");
            f1(10, 20);

            Console.WriteLine("Calling second delegate");
            f2(10, 20);

            Console.WriteLine("\nCalling chained delegates");
            f1f2(10, 20);

            // Subtract off one of the delegates            
            Console.WriteLine("\nCalling unchained delegates");
            f1f2 -= f1;
            f1f2(20, 20);

            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
