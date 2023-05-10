using System;
using System.Collections.Generic;

namespace TemperatureConverter.Models
{
    public class KelvinToFahrenheit
    {
        double StillConvertingKelvinToFahrenheit { get; set; }
        double ConvertingKelvinToFahrenheit { get; set; }

        private static List<KelvinToFahrenheit> _sixthInstance  = new List<KelvinToFahrenheit>();

        List<KelvinToFahrenheit> ForMySecondFahrenheitTemperatureList
        {
            get { return _sixthInstance; }
            set { _sixthInstance = value; }
        }

        public KelvinToFahrenheit(double myKelvinTemperature, double myStandardsOfTemperature)
        {
            StillConvertingKelvinToFahrenheit = myKelvinTemperature;
            ConvertingKelvinToFahrenheit = myStandardsOfTemperature;
            _sixthInstance.Add(this);
        }

        public double SecondKelvinToFahrenheitConverterMethod()
        {
            double trueConversion = (ConvertingKelvinToFahrenheit - 273.15) * 1.8 + 32;
            if(StillConvertingKelvinToFahrenheit < 0)
            {
                throw new ArgumentException("Invalid temperature value");
            }
            else{
                double finalKelvinToFahrenheitTemperature = trueConversion;
                return finalKelvinToFahrenheitTemperature;
            }
        }

    }
}