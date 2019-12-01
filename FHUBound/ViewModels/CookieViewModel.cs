using System;
using System.Collections.Generic;
using System.Text;
using FHUBound.Models;
namespace FHUBound.ViewModels
{
    public class CookieViewModel : BaseViewModel
    {

        public CookieGame CookieGame { get; set; }

        public CookieViewModel()
        {
            CookieGame = new CookieGame();
            CookieGame.Clicks = 0;
            CookieGame.firstLevel = 20;
            CookieGame.secondLevel = 50;
            CookieGame.thirdLevel = 100;
            CookieGame.fourthLevel = 200;
            CookieGame.fifthLevel = 350;
            CookieGame.sixthLevel = 500;
        }

    }
}
