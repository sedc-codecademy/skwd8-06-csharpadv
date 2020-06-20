using System;
using System.Collections.Generic;
using System.Text;
using TryBeingFit.Domain.Core.Enums;

namespace TryBeingFit.Domain.Core.Interfaces
{
    public interface ITraining
    {
        string Title { get; set; }
        string Description { get; set; }
        int Time { get; set; }
        Difficulty Difficulty { get; set; }
    }
}
