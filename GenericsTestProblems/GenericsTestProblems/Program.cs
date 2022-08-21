using System;

namespace GenericsTestProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Test Problems");

            Console.WriteLine("Enter First Number");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            int c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMaximum Of 3 Integer");
            int output = MaxInteger.MaximumIntegerNumber(a, b, c);
            Console.WriteLine(output);
        }
    }
}