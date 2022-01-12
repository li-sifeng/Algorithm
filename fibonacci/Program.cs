using System;

namespace FibonacciTest
{
    public class MyFibonacciTest
    {
        public static int FibonacciFun(int n)
        {
            if (0 == n)
            {
                return 0;
            }
            if (1 == n)
            {
                return 1;
            }
            else
            {
                return FibonacciFun(n-1) + FibonacciFun(n-2);
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string? input = Console.ReadLine();
            if (input != null)
            {
                int num = Convert.ToInt32(input);
                Console.WriteLine($"Fibonacci({num}) = {FibonacciFun(num)}");
            }
        }
    }
}