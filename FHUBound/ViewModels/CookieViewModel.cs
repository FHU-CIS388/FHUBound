using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using FHUBound.Models;
using Xamarin.Forms;

namespace FHUBound.ViewModels
{
    public class CookieViewModel : BaseViewModel
    {

        public CookieGame CookieGame { get; set; }

        public CookieViewModel()
        {
            

            IncrementClickCommand = new Command(IncrementClick);
        }

        


       


        public ICommand IncrementClickCommand { get; }

        void IncrementClick()
        {
            App.CurrentUser.LastName = "whoops";
            CookieGame.Clicks += 1;
            OnPropertyChanged(nameof(CookieGame.Clicks));
        }



    }
}
