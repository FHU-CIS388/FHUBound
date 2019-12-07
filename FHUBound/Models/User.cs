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
        public string FirstName { get; set; }
        public string LastName { get; set; }
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
        public string MGStatus { get; set; } = "Not Registered!";
        public bool ADVRegistered { get; set; } = false;
        public string ADVStatus { get; set; } = "Not Registered!";
        public bool IFRegistered { get; set; } = false;
        public string IFStatus { get; set; } = "Not Registered!";
        public bool CTRegistered { get; set; } = false;
        public string CTStatus { get; set; } = "Not Registered!";
        public bool ClassRegistered { get; set; } = false;
        public string ClassStatus { get; set; } = "Not Registered!";
        public int BoundBucks { get; set; }
        public int StreakLength { get; set; }
        public string MailingAddress { get; set; }
        public DateTime Birthday { get; set; }
        public User()
        {

        }
    }
}
