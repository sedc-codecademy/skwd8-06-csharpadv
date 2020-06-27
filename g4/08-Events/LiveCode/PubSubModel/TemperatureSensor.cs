using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubModel
{
    public class TemperatureSensor
    {
        //public List<SensorChange> TemperatureChanged = new List<SensorChange>();
        public event SensorChange TemperatureChanged;

        private int temperature;
        public int Temperature {
            get => temperature;
            set
            {
                temperature = value;
                if (TemperatureChanged != null)
                {
                    TemperatureChanged(temperature);
                }
                //foreach (var listener in TemperatureChanged)
                //{
                //    listener(temperature);
                //}

            }
        }

    }
}
