using System;
using System.Collections.Generic;
using System.Text;

namespace PubSubModel
{
    public class Calculator
    {
        private int temperature;
        private int windChill;

        public int Temperature { 
            get => temperature; 
            set {
                Console.WriteLine("Setting temperature");
                temperature = value;
                AffectResult();
            } 
        }

        public int WindChill
        {
            get => windChill;
            set
            {
                Console.WriteLine("Setting windchill");
                windChill = value;
                AffectResult();
            }
        }

        public int FeelsLike { get; private set; }

        public void Add()
        {
            FeelsLike = Temperature + WindChill;
        }

        private void AffectResult()
        {
            Add();
            Console.WriteLine("Here we should say that something changed");
        }

    }
}
