using System;

namespace MonthlyPaymentCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the principal loan amount");
            int P = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of years  you wish to pay off the amount");
            int Y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest");
            int R = Convert.ToInt32(Console.ReadLine());
            MonthlyPayment(P, Y, R);
        }
        static void MonthlyPayment(int P, int Y,int R)
        {
            double principal = P, numberOfYears = Y,  interestRate = R;
            double payment;
            double rate = interestRate / 1200;
            double n = 12*Y;
            payment = (principal * rate) / (1 - Math.Pow((1 + rate), (-n)));
            Console.WriteLine("Monthly payment amount is : INR {0}", payment);
        }
    }
}
