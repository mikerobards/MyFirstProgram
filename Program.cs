using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
        }

    }
    class Temperature
    {
        static float FarenheitToCelsius(float temperatureFarenheit)
        {
            Console.WriteLine("Enter Farenheit Temperature:");
            string temperatureFarenheit = Console.ReadLine();

            float temperatureCelsius = (temperatureFarenheit - 32) / 1.8f;
            return temperatureCelsius;

        }
    }
}
