using System;
using System.Collections.Generic;

namespace PerfectNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            PerfectNumber();
        }
        static void PerfectNumber()
        {
            Console.WriteLine("Enter a number to check for perfect number");
            int number = Convert.ToInt32(Console.ReadLine());
            //int[] divisors = new int[] { };
            List<int> divisors = new List<int>();
            int sumOfDivisors = 0;
            for (int i = 1; i < number; i++)
            {
                if (number % (i) == 0)
                {
                    divisors.Add(i);
                } 
            }
            foreach (int element in divisors)
            {
                Console.WriteLine(element);
                sumOfDivisors += element;
            }
            if (number==sumOfDivisors)
            {
                Console.WriteLine("{0} is a perfect number", number);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", number);
            }
        }
    }
}
