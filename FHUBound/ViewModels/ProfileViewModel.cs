using System;
using System.Collections.Generic;
using System.Text;
using FHUBound.Models;

namespace FHUBound.ViewModels
{


    public class ProfileViewModel : BaseViewModel
    {

        public User User { get; set; }


        public ProfileViewModel()
        {
            User = App.CurrentUser;
            
        }
            




        


    }
}
