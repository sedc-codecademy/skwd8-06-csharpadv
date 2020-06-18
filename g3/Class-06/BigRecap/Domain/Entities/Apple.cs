using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Apple : BaseEntity, IJucable
    {
        public double VitaminsAmount { get; set; }
        public string Taste { get; set; }

        public string MakeJuice()
        {
            double juice = VitaminsAmount * 3 / 2 + 10;
            return $"{Taste} : {juice}";
        }
    }
}
