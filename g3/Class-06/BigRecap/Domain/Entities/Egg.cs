using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Egg : BaseEntity, IProtein
    {
        public double ProteinsAmount { get; set; }
        public string Taste { get; set; }
    }
}
