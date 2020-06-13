using System;
using System.Collections.Generic;
using System.Text;

namespace Properties
{
    public class Parking
    {
        public int Capacity { get; set; }

        public int Occupied { get; set; }

        public int Free
        {
            get
            {
                return Capacity - Occupied;
            }
            set
            {
                Occupied = Capacity - value;
            }
        }

        //public int GimmeTheFreeSpaces()
        //{
        //    return Capacity - Occupied;
        //}



        public override string ToString()
        {
            return $"The parking has a {Capacity} spaces, of which {Free} are free and {Occupied} are occupied";
        }
    }
}
