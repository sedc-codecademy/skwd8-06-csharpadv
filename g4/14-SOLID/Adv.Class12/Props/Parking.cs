using System;
using System.Collections.Generic;
using System.Text;

namespace Props
{
    class Parking
    {
        private int __occupied;
        private int __capacity;

        public int Capacity { 
            get => __capacity;
            set => __capacity = value;
        }

        public int Occupied
        {
            get => __occupied;
            set {
                if (value > __capacity)
                {
                    throw new ArgumentOutOfRangeException("Unable to park more cars than capacity");
                }
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Unable to park negative cars");
                }
                __occupied = value;
            }
        }

        public int Free { }
    }
}
