using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IProtein : IFood
    {
        double ProteinsAmount { get; set; }
    }
}
