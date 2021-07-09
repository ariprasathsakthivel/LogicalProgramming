using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            Sqrt(81);
        }
        static void Sqrt(int c)
        {
            int t = c;
            //double epsilon = 1 * Math.Pow(10,-15);
            long epsilon = (long)10E-15;
            while (Math.Abs(t-c/t) > epsilon*t)
            {
                t = ((c / t) + t)/2;
            }
            Console.WriteLine(t);
        }
    }
}
