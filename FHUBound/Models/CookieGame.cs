using FHUBound.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace FHUBound.Models
{
    public class CookieGame : BaseViewModel
    {

        

        private int clicks;
        public int Clicks
        {
            get { return clicks; }
            set { SetProperty(ref clicks, value); }
        }

        private int buttonHeight = 100;
        public int ButtonHeight
        {
            get { return buttonHeight; }
            set { SetProperty(ref buttonHeight, value); }
        }


        private int buttonWidth = 100;
        public int ButtonWidth
        {
            get { return buttonWidth; }
            set { SetProperty(ref buttonWidth, value); }
        }

        private bool playAnimation = false;
        public bool PlayAnimation
        {
            get { return playAnimation; }
            set { SetProperty(ref playAnimation, value); }
        }

        private bool playFireAnimation = false;
        public bool PlayFireAnimation
        {
            get { return playFireAnimation; }
            set { SetProperty(ref playFireAnimation, value); }
        }



        public int firstLevel { get; set; }

        public int secondLevel { get; set; }

        public int thirdLevel { get; set; }

        public int fourthLevel { get; set; }

        public int fifthLevel { get; set; }

        public int sixthLevel { get; set; }

 
    }
}
