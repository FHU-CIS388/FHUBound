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


        public int firstLevel { get; set; }

        public int secondLevel { get; set; }

        public int thirdLevel { get; set; }

        public int fourthLevel { get; set; }

        public int fifthLevel { get; set; }

        public int sixthLevel { get; set; }

 
    }
}
