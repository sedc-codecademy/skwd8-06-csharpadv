using System;
using System.Collections.Generic;
using System.Text;

namespace Adv.Class03.TemperatureConverter
{
    public sealed class TemperatureConverter : IConverter
    {
        public TemperatureConverter(double value)
        {
            Value = value;
        }
        public double Value { get; }

        public double ToFahrenheit()
        {
            return Value * 9 / 5 + 32;
        }
    }
}
