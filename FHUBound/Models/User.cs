using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.Models
{
    public class User
    {
        public string Username { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int TotalPoints { get; set; }

        public int Points { get; set; }

        public int Level { get; set; }


        public User()
        {
        }
    }
}
