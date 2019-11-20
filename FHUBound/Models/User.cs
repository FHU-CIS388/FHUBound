using System;
using System.Collections.Generic;
using FHUBound.ViewModels;

namespace FHUBound.Models
{
    public class User : BaseViewModel
    {
        private int currentPoints = 0;
        public int CurrentPoints
        {
            get { return currentPoints; }
            set { SetProperty(ref currentPoints, value); }
        }
        public string Id { get; set; }
        public string Username { get; set; }

        public string Avatar { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string Email { get; set; }

        public User()
        {
        }
    }
}
