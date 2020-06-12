using System;
using System.Collections.Generic;
using System.Text;

namespace TreeOfTrees
{
    interface ITaxiDriver : IDriver
    {
        bool HaveArrived { get; set; }

        void SetDestination(string destination);

        double GetPrice();

        void Pay();
    }
}
