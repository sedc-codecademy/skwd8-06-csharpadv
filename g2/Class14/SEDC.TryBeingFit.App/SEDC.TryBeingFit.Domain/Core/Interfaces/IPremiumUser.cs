﻿using SEDC.TryBeingFit.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.TryBeingFit.Domain.Core.Interfaces
{
    public interface IPremiumUser
    {
        LiveTraining LiveTraining { get; set; }
    }
}
