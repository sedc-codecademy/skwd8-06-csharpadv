using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adc.Class05.Generics.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
