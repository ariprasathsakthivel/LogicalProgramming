using System;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a postive number");
            int num = Convert.ToInt32(Console.ReadLine());
            PrimeCheck(num);
        }
        static void PrimeCheck(int num)
        {
            int number = num;
            string flag = "prime";
            if (number > 0)
            {
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        flag = "not prime";
                    }
                }
                if (flag == "not prime")
                {
                    Console.WriteLine("{0} is not a prime number", number);
                }
                else if (number == 1)
                {
                    Console.WriteLine("{0} is neither prime nor non-prime", number);
                }
                else if (flag == "prime")
                {
                    Console.WriteLine("{0} is a prime number", number);
                }
            }
            else
            {
                Console.WriteLine("Enter a valid number");
                Program.Main(null);
            }
        }
    }
}
