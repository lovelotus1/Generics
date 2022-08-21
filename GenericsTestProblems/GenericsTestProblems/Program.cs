using System;

namespace GenericsTestProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Test Problems");

            Console.WriteLine("Enter First Number");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            double c = Convert.ToDouble(Console.ReadLine()); ;

            Console.WriteLine("\nMaximum Of 3 Float");
            double output = MaxFloat.MaximumFloatNumber(a, b, c);
            Console.WriteLine(output);
        }
    }
}