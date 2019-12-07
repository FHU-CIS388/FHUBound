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

        public AnimationView CookieAnimation { get; set; }

        public CookieViewModel(ImageButton imageButton, AnimationView animationView, AnimationView cookieAnimation)
        {
            CookieGame = new CookieGame();
            ImageButton = imageButton;
            CookieGame.ButtonWidth = 300;
            CookieGame.ButtonHeight = 300;
            AnimationView = animationView;
            CookieAnimation = cookieAnimation;

            IncrementClickCommand = new Command(IncrementClick);

            AnimationView.OnFinish += FireAnimationView_OnFinish;
            CookieAnimation.OnFinish += AnimationView_OnFinish;

        }

        private void AnimationView_OnFinish(object sender, EventArgs e)
        {
            
            CookieGame.PlayAnimation = false;
        }

        private void FireAnimationView_OnFinish(object sender, EventArgs e)
        {

            CookieGame.PlayFireAnimation = false;
        }


        public ICommand IncrementClickCommand { get; }

        public bool hold = true;
      


         async void IncrementClick()
        {
            
            CookieGame.Clicks += 1;
            await ImageButton.ScaleTo(1.05, 75, Easing.BounceIn);
            await ImageButton.ScaleTo(1, 75, Easing.BounceOut);

            if (CookieGame.Clicks % 25 == 0)
            {
                App.CurrentUser.Points += 10;
                App.CurrentUser.TotalPoints += 10;
                App.CurrentUser.CalculateLevel();

                CookieGame.PlayAnimation = true;
                CookieAnimation.Play();
                
                //CookieGame.PlayAnimation = false;
                
            }

            if (CookieGame.Clicks % 100 == 0)
            {
                CookieGame.PlayFireAnimation = true;

                AnimationView.Play();
            }


            

           
            
        }



    }
}
