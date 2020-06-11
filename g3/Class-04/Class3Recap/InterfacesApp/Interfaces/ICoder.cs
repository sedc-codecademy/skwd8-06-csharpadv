using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp.Interfaces
{
    public interface ICoder
    {
        List<string> Languages { get; set; }
        void Code();
    }
}
