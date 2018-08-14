using System;

namespace _4_ComposableDelegates2
{
    // Step 1
    // Declare the delegate type
    // Using reference parameter enables results to be passed from one delegate to the next
    public delegate void MyDelegate(int arg1, ref int arg2);

    class Program
    {
        // Step 2
        // Implement function that serves as a version of the delegate
        static void func1(int arg1, ref int arg2)
        {
            string result = (arg1 + arg2).ToString();

            //arg2 is a ref parameter, so this will change 
            arg2 += 20;
            Console.WriteLine("The number is: " + result);
        }

        static void func2(int arg1, ref int arg2)
        {
            string result = (arg1 * arg2).ToString();
            Console.WriteLine("The number is: " + result);
        }

        static void Main(string[] args)
        {
            int a = 10, b = 10;
            MyDelegate f1 = func1;
            MyDelegate f2 = func2;
            MyDelegate combined = f1 + f2;

            Console.WriteLine($"The value of b is: {b}");
            combined(a, ref b);
            Console.WriteLine($"The value of b is: {b}");

            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
