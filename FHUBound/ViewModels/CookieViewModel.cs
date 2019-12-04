using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using FHUBound.Models;
using Lottie.Forms;
using Xamarin.Forms;

namespace FHUBound.ViewModels
{
    public class CookieViewModel : BaseViewModel
    {

        public CookieGame CookieGame { get; set; }
        public ImageButton ImageButton { get; set; }
        public AnimationView AnimationView { get; set; }

        public AnimationView FireAnimation { get; set; }

        public CookieViewModel(ImageButton imageButton, AnimationView animationView, AnimationView fireAnimation)
        {
            CookieGame = new CookieGame();
            ImageButton = imageButton;
            CookieGame.ButtonWidth = 300;
            CookieGame.ButtonHeight = 300;
            AnimationView = animationView;
            FireAnimation = fireAnimation;

            IncrementClickCommand = new Command(IncrementClick);

            AnimationView.OnFinish += AnimationView_OnFinish;
        }

        private void AnimationView_OnFinish(object sender, EventArgs e)
        {
            
            CookieGame.PlayAnimation = false;
        }

        public ICommand IncrementClickCommand { get; }

        public bool hold = true;
      


         async void IncrementClick()
        {
            
            CookieGame.Clicks += 1;
            await ImageButton.ScaleTo(1.05, 100, Easing.BounceIn);
            await ImageButton.ScaleTo(1, 100, Easing.BounceOut);

            if (CookieGame.Clicks % 5 == 0)
            {
                CookieGame.PlayAnimation = true;
                AnimationView.Play();
                FireAnimation.Play();
                //CookieGame.PlayAnimation = false;
                
            }
            

           
            
        }



    }
}
