using System;
using FHUBound.Models;

namespace FHUBound.ViewModels
{
    public class ProfileViewModel
    {
        public User User { get; set; }
        public string Message { get; set; }

        public ProfileViewModel()
        {
            User = App.CurrentUser;
            Message = "Good Morning, " + User.Username;
        }
    }
}
