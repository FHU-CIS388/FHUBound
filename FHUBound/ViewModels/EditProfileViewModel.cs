using System;
using System.Collections.Generic;
using System.Text;
using FHUBound.Models;

namespace FHUBound.ViewModels
{

   
    public class EditProfileViewModel : BaseViewModel
    {

        public User User { get; set; }

        public EditProfileViewModel()
        {
            User = App.CurrentUser;
        }


    }
}
