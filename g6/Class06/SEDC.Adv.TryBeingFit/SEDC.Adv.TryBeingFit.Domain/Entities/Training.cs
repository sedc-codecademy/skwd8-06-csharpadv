using SEDC.Adv.TryBeingFit.Domain.Enums;
using SEDC.Adv.TryBeingFit.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain.Entities
{
    public abstract class Training : BaseEntity, ITraining
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Time { get; set; }
        public Difficulty Difficulty { get; set; }
        public int Rating { get; set; }
        public virtual string CheckRating()
        {
            if (Rating == 1)
            {
                return "Bad";
            }
            if (Rating < 3)
            {
                return "Okay";
            }
            if (Rating > 3)
            {
                return "Good";
            }

            return "Unknown";
        }
    }
}
