using System;

namespace _1_BasicLambdas
{
    // Define a few delegate types
    public delegate int MyDelegate(int x);
    public delegate void MyDelegate2(int x, string prefix);
    public delegate bool ExpreSelegate(int x);

    class Program
    {
        static void Main(string[] args)
        {
            // Create a basic delegate that squares a number
            MyDelegate foo = (x) => x * x;
            Console.WriteLine($"The result of foo is: {foo(5)}");

            // Dinamically change the delegate to something else
            foo = (x) => x * 10;
            Console.WriteLine($"The result of foo is: {foo(5)}");

            // Create a delegate taht takes multiple arguments
            // Statement lambda
            MyDelegate2 bar = (x, y) =>
            {
                Console.WriteLine($"The two-arg lambda: {y}, {x * 10}");
            };
            bar(25, "Some string");

            // Define an expression delegate
            ExpreSelegate baz = (x) => x > 10;
            Console.WriteLine($"Calling baz with 5 {baz(5)}");
            Console.WriteLine($"Calling baz with 15 {baz(15)}");

            Console.WriteLine("\nPress Enter Key to Continue...");
            Console.ReadLine();
        }
    }
}
