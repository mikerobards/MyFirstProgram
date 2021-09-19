using System;
using System.Globalization;

namespace MyFirstProgram
{
    // class Program
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Hello World!");
    //     }

    // }
    class Temperature
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Farenheit Temperature:");
            string temperatureFarenheitString = Console.ReadLine();
            float temperatureFarenheit = float.Parse(temperatureFarenheitString, CultureInfo.InvariantCulture.NumberFormat);
            Console.WriteLine(Temperature.FarenheitToCelsius(temperatureFarenheit));

        }
        static float FarenheitToCelsius(float temperatureFarenheit)
        {
            float temperatureCelsius = (temperatureFarenheit - 32) / 1.8f;
            return temperatureCelsius;
        }
    }
}
