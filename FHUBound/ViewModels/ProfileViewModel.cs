using System;
using System.Collections.Generic;
using System.Text;
using FHUBound.Models;
using System.ComponentModel;

namespace FHUBound.ViewModels
{
    class ProfileViewModel
    {
        public User User { get; set; }

        

        

        public ProfileViewModel()
        {
            User = App.CurrentUser;
        }
    }
}
