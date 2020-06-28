using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubModel
{
    public class Calculator
    {
        private int temperature;
        private int windChill;

        public event SensorChange FeelsLikeChanged;

        public int Temperature { 
            get => temperature; 
            set {
                temperature = value;
                AffectResult();
            } 
        }

        public int WindChill
        {
            get => windChill;
            set
            {
                windChill = value;
                AffectResult();
            }
        }

        public int FeelsLike { get; private set; }

        public void Add()
        {
            FeelsLike = Temperature + WindChill;
            FeelsLikeChanged?.Invoke(FeelsLike);
        }

        private void AffectResult()
        {
            Add();
        }

    }
}
