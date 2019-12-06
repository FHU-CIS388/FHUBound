using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.Models
{
    public class User
    {
        public string ImagePath { get; set; }
        public string Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; } 
        public string Password { get; set; }
        private bool mgRegistered;
        public bool MGRegistered
        {
            get
            {
                return mgRegistered;
            }
            set
            {
                mgRegistered = value;
                if (value) MGStatus = "Registered!";
                else MGStatus = "Not Registered";
            }
        }
        public string MGStatus { get; set; }
        public bool AdvRegistered { get; set; }
        public bool IFRegistered { get; set; }
        public int BoundBucks { get; set; }
        public int StreakLength { get; set; }
        public string MailingAddress { get; set; }
        public DateTime Birthday { get; set; }
    }
}
