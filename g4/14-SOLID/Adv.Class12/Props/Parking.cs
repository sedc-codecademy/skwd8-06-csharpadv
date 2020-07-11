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
            get
            {
                Console.WriteLine("Getter called");
                return __occupied;
            }
            set {
                Console.WriteLine("Setter called");
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

        internal bool AreThereFreeSpaces()
        {
            return Free > 0;
        }

        public int Free 
        {
            get 
            {
                return __capacity - __occupied;
            }
            set
            {
                // todo: validation
                __occupied = __capacity - value;
            }
        }

        public bool HasFree
        {
            get => Free > 0;
        }
    }
}
