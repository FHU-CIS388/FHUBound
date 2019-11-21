using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.Models
{
    public class User
    {
        public string ImagePath { get; set; }
        public string Name { get; set; }
        public bool MGRegistered { get; set; }
        public bool AdvRegistered { get; set; }
        public bool IFRegistered { get; set; }
        public int BoundBucks { get; set; }
        public int StreakLength { get; set; }
    }
}
