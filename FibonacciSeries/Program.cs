using System;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the limit N");
            int N = Convert.ToInt32(Console.ReadLine());
            FibonacciSeries(N);
        }
        static void FibonacciSeries(int N)
        {
            int sumValue1 = 0, sumValue2 = 1, values;
            Console.WriteLine(sumValue1);
            Console.WriteLine(sumValue2);
            for (int i=0; (sumValue1+sumValue2)<N; i++)
            {
                values= sumValue1 + sumValue2;
                sumValue1 = sumValue2;
                sumValue2 = values;
                Console.WriteLine(values);
            }
        }
    }
}
