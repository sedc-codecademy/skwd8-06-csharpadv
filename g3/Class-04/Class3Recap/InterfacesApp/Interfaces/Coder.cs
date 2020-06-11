using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesApp.Interfaces
{
    public abstract class Coder
    {
        public abstract List<string> Languages { get; set; }
        public abstract void Code();
    }
}
