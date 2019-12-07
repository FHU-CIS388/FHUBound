using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.Models
{
    public class User
    {
        public string Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string Address { get; set; }

        public int Points { get; set; }

        public DateTime Birthday { get; set; }

        public User()
        {

        }
    }
}
