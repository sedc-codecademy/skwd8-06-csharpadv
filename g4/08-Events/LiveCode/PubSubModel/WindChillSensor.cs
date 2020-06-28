using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubModel
{
    public class WindChillSensor
    {
        public event SensorChange WindChillChanged;

        private int windChill;
        public int WindChill
        {
            get => windChill;
            set
            {
                windChill = value;
                WindChillChanged?.Invoke(windChill);
            }
        }

    }
}
