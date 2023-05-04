using System;
using System.Collections.Generic;

namespace TemperatureConverter.Models
{
    public class CelsiusToFahrenheit
    {

        public double StillConvertingCelsiusToFahrenheit{ get; set; }
        public double ConvertingCelsiusToFahrenheit{ get; set; }

        public List<CelsiusToFahrenheit> _fourthInstance;
        public List<CelsiusToFahrenheit> ForMyListOfCelsiusToFahreheitTemperatures
        {
            get {return _fourthInstance; }
            set {_fourthInstance = value; }
        }

        public CelsiusToFahrenheit(double mySecondFahrenheitTemp, double standardOfFahrenheitTemp)
        {
            StillConvertingCelsiusToFahrenheit = mySecondFahrenheitTemp;
            ConvertingCelsiusToFahrenheit = standardOfFahrenheitTemp;
            _fourthInstance.Add(this);
        }

        public double SecondFahrenheitConverterMethod()
        {
            // how a temperature in Celsius is converted to one in Fahrenhe
            double realConversion = (ConvertingCelsiusToFahrenheit * 1.8) +32;
            if(StillConvertingCelsiusToFahrenheit < 0)
            {
                throw new ArgumentException("Invalid temperature value");
            }
            else{
                double finalCelsiusToFahrenheitTemperature = realConversion;
                return finalCelsiusToFahrenheitTemperature;
            }
        }


    }
}