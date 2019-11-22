using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using FHUBound.Models;
using System.Collections.ObjectModel;

namespace FHUBound.ViewModels
{
    class ProfileViewModel : BaseViewModel
    {
        User CurrentUser { get; set; }
        string Name { get; set; }
        public ProfileViewModel()
        {
                     
        }
    }
}
