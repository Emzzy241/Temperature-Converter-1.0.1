using System;
using System.Collections.Generic;

namespace TemperatureConverter.Models
{
    public class CelsiusToFahrenheit
    {

        public double StillConvertingCelsiusToFahrenheit{ get; set; }
        public double ConvertingCelsiusToFahrenheit{ get; set; }

        public List<CelsiusToFahrenheit> _fourthInstance
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

        p


    }
}