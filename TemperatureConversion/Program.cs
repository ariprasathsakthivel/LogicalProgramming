using System;

namespace TemperatureConversion
{
    class Program
    {
        static void Main(string[] args)
        {
            TemperatureConversion();
        }
        static void TemperatureConversion()
        {
            Console.WriteLine("Enter the output temperature unit. Enter 'f' for Fahrenheit and 'c' for Celcius");
            char key = Convert.ToChar(Console.ReadLine());
            switch (key)
            {
                case 'f':
                    Console.WriteLine("Enter the temperature in degreeCelcius. Limit should be between 0 and 100");
                    int degC = Convert.ToInt32(Console.ReadLine());
                    CelciusToFahrenheit(degC);
                    break;
                case 'c':
                    Console.WriteLine("Enter the tempurature in degreeFahrenheit. Limit should be between 32 adn 212");
                    int degF = Convert.ToInt32(Console.ReadLine());
                    FahrenheitToCelcius(degF);
                    break;
            }
        }
        static void CelciusToFahrenheit(int degC)
        {
            int degF = (degC * 9 / 5) + 32;
            Console.WriteLine(degF);
        }
        static void FahrenheitToCelcius(int degF)
        {
            int degC = (degF - 32) * 5 / 9;
            Console.WriteLine(degC);
        }
    }
}
