using System;

namespace StaticExerciseUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature in Fahrenheit?");
            var farenheit = int.Parse(Console.ReadLine());
            var celcius = TempConverter.FahrenheitToCelsius(farenheit);
            Console.WriteLine($"The temperature converted to Celcius is {celcius}");

            Console.WriteLine("What is the temperature in Celcius?");
            var celcius2 = int.Parse(Console.ReadLine());
            var fahrenheit2 = TempConverter.CelsiusToFahrenheit(celcius2);
            Console.WriteLine($"The temperature converted to Fahreneit is {fahrenheit2}"); 

        }
    }
}
