
using System;
using System.Collections.Generic;

namespace DecimalToBinaryBase2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number to convert: ");
            int number = int.Parse(Console.ReadLine());
            BinaryBase2(number);
        }
        static void BinaryBase2(int number)
        {
            int n = number, count=0, i;
            List<int> binary = new List<int>();
            for (i = 0; n >= 0; i++)
            {
                if (n == 0)
                {
                    binary.Add(n);
                    break;
                }
                else
                {
                    binary.Add(n % 2);
                    n = n / 2;
                }
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                if (binary[i] == 1)
                {
                    if (count == 0)
                    {
                        Console.Write("{0} = {1}", number, Math.Pow(2, i));
                        count++;
                    }
                    else
                    {
                        Console.Write("+{0}", Math.Pow(2, i));
                    }
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
