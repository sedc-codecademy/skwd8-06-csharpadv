using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IJucable : IFood
    {
        double VitaminsAmount { get; set; }
        string MakeJuice();
    }
}
