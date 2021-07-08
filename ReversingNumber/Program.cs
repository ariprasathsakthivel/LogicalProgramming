using System;

namespace ReversingNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a positive number");
            int num = Convert.ToInt32(Console.ReadLine());
            ReverseNumber(num);
        }
        static void ReverseNumber(int num)
        {
            int number = num, reversednumber = 0, temp;
            while (number != 0)
            {
                temp = number % 10;
                number -= temp;
                number /= 10;
                reversednumber += temp;
                reversednumber *= 10;
            }
            Console.WriteLine("Reversed number is {0}", reversednumber / 10);
        }
    }
}
