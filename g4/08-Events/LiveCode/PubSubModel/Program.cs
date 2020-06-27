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

            TemperatureSensor ts = new TemperatureSensor();
            ts.TemperatureChanged = enDisplay.ShowTemperature;

            // this happens tomorrow
            ts.Temperature = 25;
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
