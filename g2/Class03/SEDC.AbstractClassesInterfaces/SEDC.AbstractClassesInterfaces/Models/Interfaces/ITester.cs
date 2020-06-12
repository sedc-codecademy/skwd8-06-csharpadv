using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.AbstractClassesInterfaces.Models.Interfaces
{
    public interface ITester
    {
        bool IsAutomated { get; set; }
        void TestFeature(string feature);
    }
}
