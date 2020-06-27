using System;
using System.Collections.Generic;
using System.Text;

namespace SEDC.Adv.TryBeingFit.Domain
{
    public class VideoTraining : Training, IVideoTraining
    {
        public string Link { get; set; }

        public override string Info()
        {
            return $"[{Difficulty}] {Title} - {Description}";
        }
    }
}
