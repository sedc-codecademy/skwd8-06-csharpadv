using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsExample.Enteties
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
