using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp.Interfaces
{
    public interface ICook
    {
        string Food { get; set; }
        void Cook();
    }
}
