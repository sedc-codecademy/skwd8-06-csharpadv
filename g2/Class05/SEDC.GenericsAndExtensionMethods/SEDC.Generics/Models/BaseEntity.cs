﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Generics.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public abstract string GetInfo();
    }
}
