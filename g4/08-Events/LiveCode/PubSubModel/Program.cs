using System;

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

            Display enDisplay = new Display();
            SevenSegmentDisplay ssDisplay = new SevenSegmentDisplay();

            TemperatureSensor ts = new TemperatureSensor();
            //ts.TemperatureChanged.Add(enDisplay.ShowTemperature);
            //ts.TemperatureChanged.Add(ssDisplay.DisplayTemp);
            ts.TemperatureChanged += enDisplay.ShowTemperature;
            ts.TemperatureChanged += ssDisplay.DisplayTemp;

            // this happens tomorrow
            ts.Temperature = 25;

            //ts.TemperatureChanged.Remove(ssDisplay.DisplayTemp);
            ts.TemperatureChanged -= ssDisplay.DisplayTemp;

            ts.Temperature = 30;


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
