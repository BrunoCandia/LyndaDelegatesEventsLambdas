using System;

namespace _2_AnonymousDelegates
{
    // Step 1
    // Declare the delegate type
    public delegate string MyDelegate(int arg1, int arg2);

    class Program
    {
        static void Main(string[] args)
        {
            // Step 2
            // The delegate keyboard declares the function in line
            MyDelegate f = delegate (int arg1, int arg2)
            {
                return (arg1 + arg2).ToString();
            };

            Console.WriteLine("The number is: " + f(10, 20));

            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
