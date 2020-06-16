using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class03.TemperatureConverter
{
    public static class TemperatureConverterExtensions
    {
        public static double ToKevin(this TemperatureConverter temperature)
        {

            return temperature.Value + 273.15;
        }
    }
}
