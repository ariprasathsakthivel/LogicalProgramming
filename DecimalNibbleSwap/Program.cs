using System;
using System.Collections.Generic;

namespace DecimalNibbleSwap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number between 0 to 255 to convert: ");
            int number = int.Parse(Console.ReadLine());
            ToBinary(number);
        }
        static void ToBinary(int number)
        {
            int n = number, i, finalNumber=0;
            List<int> binary = new List<int>(); //list for storing the generated binary numbers.
            List<int> binaryReversed = new List<int>(); //list for storing the reversed binary number i.e., actual binary numbers.
            List<int> binaryswapped = new List<int>(); //list for storing the binary numbers after the nibles are swapped.
            for (i = 0; n >= 0; i++)  //this for loop finds the binary numbers of the decimal number.
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
            for (; i >= 0; i--) //for loop for reversing the binary numbers
            {
                binaryReversed.Add(binary[i]);
            }
            for (int j = 4; j <= 7; j++) //the nest two for loops are for swaping the nibles and storing it in a list
            {
                binaryswapped.Add(binaryReversed[j]);
            }
            for (int j = 0; j < 4; j++)
            {
                binaryswapped.Add(binaryReversed[j]);
            }
            for (int j = 7, count = 0; j >= 0; j--, count++) //this for loop is for converting the binary numbers after swaping into decimal numbers.
            {
                if (binaryswapped[j] == 1)
                {
                    finalNumber += Convert.ToInt32(Math.Pow(2, count));
                }
            }
            Console.WriteLine(finalNumber); //printing the final decimal number after the nibles are swapped.
        }
    }
}
