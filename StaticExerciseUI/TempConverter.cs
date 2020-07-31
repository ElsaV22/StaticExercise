using System;
using System.Collections.Generic;
using System.Text;

namespace StaticExerciseUI
{
    public static class TempConverter
    {
        public static double FahrenheitToCelsius(double farenheit)
        {
            var result = (farenheit - 32) /1.8;
            return result;

        }

        public static double CelsiusToFahrenheit(double celcius)
        {
            return (celcius * 9) / 5 + 32;
        
        }
    }


}
