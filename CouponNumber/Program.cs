using System;
using System.Collections.Generic;

namespace CouponNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many Coupons do you need? Enter a Positive number");
            int N = Convert.ToInt32(Console.ReadLine()); 
            Coupon(N);
        }
        static void Coupon(int N)
        {
            int count = N - 1, number;
            List<int> coupons = new List<int>();
            coupons.Add(NumberGenerator()); //initializing the list with random number
            while (count != 0)
            {
                number = NumberGenerator(); //generating a random number using the method NumberGenerator
                foreach (int element in coupons)
                {
                    if (element == number) //Checking the generated number is already present in the list or not
                    {
                        break;
                    }
                    else
                    {
                        coupons.Add(number);
                        count--;
                        break;
                    }
                }
            }
            DisplayCoupons(coupons);
        }
        static int NumberGenerator() // method for generating a random number
        {
            Random random = new Random();
            return random.Next(10, 100); //assuming the limit between 10 to 100 for generating a 2 digit coupon number
        }
        static void DisplayCoupons(List<int> coupons)  //method for displaying all the coupon numbers
        {
            Console.WriteLine("Coupon nnumbers are: ");
            foreach (int element in coupons)
            {
                Console.WriteLine(element);
            }
        }

    }
}
