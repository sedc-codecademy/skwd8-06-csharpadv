using System;

namespace Adv.Class03.TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var celsius = new Celsius(123.5);

            Console.WriteLine($"Celsius to fahrenheit is: " + celsius.Fahrenheit());
            Console.WriteLine($"Celsius to Kevin is : " + celsius.ToKevin());

            Console.ReadLine();
        }
    }

    public class Celsius
    {
        private TemperatureConverter _converter;
        public Celsius(double celsius)
        {
            _converter = new TemperatureConverter(celsius);
        }

        public double Fahrenheit()
        {
            return _converter.ToFahrenheit();
        }
        public double ToKevin()
        {
            return _converter.ToKevin(); ;
        }
    }
}
