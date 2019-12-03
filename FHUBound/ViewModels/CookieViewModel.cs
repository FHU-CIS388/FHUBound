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
        public ImageButton ImageButton { get; set; }

        public CookieViewModel(ImageButton imageButton)
        {
            CookieGame = new CookieGame();
            ImageButton = imageButton;

            IncrementClickCommand = new Command(IncrementClick);
        }


        public ICommand IncrementClickCommand { get; }

        public bool hold = true;

        async void IncrementClick()
        {
            
            CookieGame.Clicks += 1;

            if (hold)
            {
                await ImageButton.TranslateTo(50, 50, 500);
                hold = false;
            }
            else
            {
                await ImageButton.TranslateTo(-50, -50, 500);
                hold = true;
            }
            
            
        }



    }
}
