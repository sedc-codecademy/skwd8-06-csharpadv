﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Platform
    {
        public Guid Id{ get; set; }
        public string Name { get; set; }
        public List<User> Users { get; set; }
    }
}
