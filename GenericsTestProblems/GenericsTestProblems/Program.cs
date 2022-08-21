using System;

namespace GenericsTestProblems
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Generics Test Problems");

            Console.WriteLine("Enter First Number");
            string a = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Second Number");
            string b = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Enter Third Number");
            string c = Convert.ToString(Console.ReadLine());

            Console.WriteLine("\nMaximum Of 3 String");
            string output = MaxString.MaximumFloatNumber(a, b, c);
            Console.WriteLine(output);
        }
    }
}