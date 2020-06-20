using System;
using System.Collections.Generic;
using System.Text;
using TryBeingFit.Domain.Core.Enums;
using TryBeingFit.Domain.Core.Interfaces;

namespace TryBeingFit.Domain.Core.Entities
{
    public abstract class Training : BaseEntity, ITraining
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public Difficulty Difficulty { get; set; }
    }
}
