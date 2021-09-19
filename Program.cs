using System;
using System.Globalization;
using MyUtilities;

namespace MyFirstProgram
{
    class CheckComfort
    {
        static void Main(string[] args)
        {
            WeatherUtilities.Report("Kennesaw", 23, 65); // ~73F
        }

    }
    // class Temperature
    // {
    //     static void Main(string[] args)
    //     {
    //         Console.WriteLine("Enter Farenheit Temperature:");
    //         string temperatureFarenheitString = Console.ReadLine();
    //         decimal temperatureFarenheit = decimal.Parse(temperatureFarenheitString, CultureInfo.InvariantCulture.NumberFormat);
    //         Console.WriteLine(Temperature.FarenheitToCelsius(temperatureFarenheit));

    //     }
    //     static decimal FarenheitToCelsius(decimal temperatureFarenheit)
    //     {
    //         decimal temperatureCelsius = (temperatureFarenheit - 32M) / 1.8M;
    //         int result = (int)temperatureCelsius;
    //         // return result;
    //         Console.WriteLine(temperatureCelsius);
    //         if (temperatureCelsius - result >= 0.5M)
    //         {
    //             return Math.Ceiling(temperatureCelsius);
    //         }
    //         else
    //         {
    //             return Math.Floor(temperatureCelsius);
    //         }
    //     }
}
}
