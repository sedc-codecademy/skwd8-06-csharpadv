using System;
using System.Collections.Generic;
using System.Text;

namespace SerializationDeserializationApp
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public override string ToString()
        {
            //return typeof(Car).FullName; // Default behaviour of ToString()
            //return $"Brand: {Brand}; Model: {Model}; Year: {Year}; Color: {Color}"; // Custom properties string
            return "{" +
                "  \"brand\": " + "\"" + Brand + "\"," +
                "  \"model\": " + "\"" + Model + "\"," +
                "  \"year\": " + "\"" + Year + "\"," +
                "  \"color\": " + "\"" + Color + "\"" +
                "}";
        }
    }
}
