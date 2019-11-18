using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.Models
{
    class Profile
    {
        string ImagePath { get; set; }
        string Name { get; set; }
        bool MGRegistered { get; set; }
        bool AdvRegistered { get; set; }
        bool IFRegistered { get; set; }
        int BoundBucks { get; set; }
        int StreakLength { get; set; }
    }
}
