using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using FHUBound.Models;

namespace FHUBound.ViewModels
{
    class ProfileViewModel : BaseViewModel
    {

        public ProfileViewModel()
        {
            App.CurrentUser = new User()
            {
                Name = "John Doe",
                ImagePath = "profile.jpg"
            };
        }
    }
}
