using StoreExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreExample.Enteties
{
    public class LiquirStore : Store, IUsingParking
    {
        public int ParkingCapacity { get; set; }
        public int Parkedehicles { get; set; }
        public bool HaveAvaliableSpaces()
        {
            if (Parkedehicles < ParkingCapacity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
