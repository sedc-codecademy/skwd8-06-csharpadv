using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubModel
{
    public delegate void SensorChange(int sensorValue);

    public class TemperatureSensor
    {
        public SensorChange TemperatureChanged;

        private int temperature;
        public int Temperature {
            get => temperature;
            set
            {
                temperature = value;
                TemperatureChanged(temperature);
            }
        }

    }
}
