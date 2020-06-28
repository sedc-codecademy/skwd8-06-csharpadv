using System;
using System.Net.WebSockets;

namespace PubSubModel
{
    class Program
    {
        static void Main(string[] args)
        {
            //var calculator = new Calculator();

            //// setting up input values
            //calculator.Temperature = 5;
            //calculator.WindChill = 10;

            // // output result
            //Console.WriteLine(calculator.FeelsLike);

            //calculator.Temperature = 10;
            //Console.WriteLine(calculator.FeelsLike);

            //Display enDisplay = new Display();
            //SevenSegmentDisplay ssDisplay = new SevenSegmentDisplay();

            //TemperatureSensor ts = new TemperatureSensor();
            ////ts.TemperatureChanged.Add(enDisplay.ShowTemperature);
            ////ts.TemperatureChanged.Add(ssDisplay.DisplayTemp);
            //ts.TemperatureChanged += enDisplay.ShowTemperature;
            //ts.TemperatureChanged += ssDisplay.DisplayTemp;

            //// this happens tomorrow
            //ts.Temperature = 25;

            //ts.Temperature = 12345;
            //ts.Temperature = 67890;

            ////ts.TemperatureChanged.Remove(ssDisplay.DisplayTemp);
            //ts.TemperatureChanged -= ssDisplay.DisplayTemp;

            //ts.Temperature = 30;

            var calculator = new Calculator();
            var ts = new TemperatureSensor();
            var wcs = new WindChillSensor();
            var ssDisplay = new SevenSegmentDisplay();

            ts.TemperatureChanged += (temp) => calculator.Temperature = temp;
            wcs.WindChillChanged += (wc) => calculator.WindChill = wc;

            calculator.FeelsLikeChanged += (value) => ssDisplay.DisplayTemp(value);
            calculator.FeelsLikeChanged += (value) =>
            {
                if (value > 25)
                {
                    Console.WriteLine("Turning on AC");
                }
                if (value <20)
                {
                    Console.WriteLine("Turning off AC");
                }
            };

            ts.Temperature = 20;
            wcs.WindChill = -3;
        }

        static void ShowTemperature(int temp)
        {
            Console.WriteLine($"TEMP IS {temp}");
        }

        static void ShowTemperature2(int temp)
        {
            Console.WriteLine($"Temperature is {temp}");
        }

    }
}
