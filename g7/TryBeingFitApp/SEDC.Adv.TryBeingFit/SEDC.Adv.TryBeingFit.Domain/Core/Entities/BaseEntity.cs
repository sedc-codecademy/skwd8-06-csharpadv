using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    public abstract class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public abstract string Info();
    }
}
