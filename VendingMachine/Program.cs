using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the change amount");
            int totalChange = Convert.ToInt32(Console.ReadLine());
            Change(totalChange);
        }
        static void Change(int totalChange)
        {
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noteCount = new int[7];
            int j = 0;
            for (int i = 0; i < 7; i++)
            {
                if (totalChange >= notes[i])
                {
                    noteCount[i] = totalChange / notes[i];
                    totalChange = totalChange - noteCount[i] * notes[i];
                }

            }
            foreach (int count in noteCount)
            {
                Console.WriteLine(" Number of {0} are {1}", notes[j], count);
                j++;
            }
        }
    }
}
