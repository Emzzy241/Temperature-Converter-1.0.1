// This is the class file for the conversion of Fahrenheit to Celsius Temperature

using System;
using System.Collections.Generic;


// a method that takes in a fahrenheit Temperature and converts to celsius temperature

namespace TemperatureConverter.Models
{


    public class FahrenheitToCelsius
    {
        public double StillConvertingFahrenheitToCelsius { get; set; }
        public double ConvertingfahrenheitToCelsius { get; set; }

        private static List<FahrenheitToCelsius> _thirdInstances = new List<FahrenheitToCelsius>();

        public List<FahrenheitToCelsius> ForMyFahrenheitToCelsiusTemperatureList
        {
            get { return _thirdInstances; }
            set { _thirdInstances = value; }
        }

        // my constructor that helps me to handle the different C# properties I've written

        public FahrenheitToCelsius(double fahrenheitTemperature, double standardOfFahrenheitoCelsius)
        {
            StillConvertingFahrenheitToCelsius = fahrenheitTemperature;
            ConvertingfahrenheitToCelsius = standardOfFahrenheitoCelsius;
            _thirdInstances.Add(this);
        }

        public double FahrenheitConverterMethod()
        {

            // double realConversion = (ConvertingfahrenheitToCelsius * 1.8) +32;


            double realConversion = (ConvertingfahrenheitToCelsius -32)* 1.8;


            if ((StillConvertingFahrenheitToCelsius < 0))
            {
                throw new ArgumentException("Invalid temperature in kelvin");
            }
            else{
                double finalFahrenheitValue = realConversion;
                return finalFahrenheitValue;
            }
        }


    }


}

