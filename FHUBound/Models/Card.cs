using System;
using FHUBound.ViewModels;
namespace FHUBound.Models
{
    public class Card: BaseViewModel
    {
        public string HeaderTitle { get; set; } = "";
        public string HeaderSubtitle { get; set; } = "";
        public string HeaderBackgroundColor { get; set; } = "";
        public string HeaderForegroundColor { get; set; } = "";
        

        public string ImageUrl { get; set; } = "";
        public string VideoUrl { get; set; } = "";

        public string BodyTitle { get; set; } = "";
        public string BodySubtitle { get; set; } = "";
        public string BodyContent { get; set; } = "";
        public string BodyBackgroundColor { get; set; } = "";
        public string BodyForegroundColor { get; set; } = "";

        public string ButtonUrl { get; set; } = "";
        public string ButtonText { get; set; } = "";
        public string ButtonBackgroundColor { get; set; } = "";
        public string ButtonForegroundColor { get; set; } = "";

        private bool pointsNotCollected = true;
        public bool PointsNotCollected {
            get { return pointsNotCollected; }
            set { SetProperty(ref pointsNotCollected, value); } 
        } 

        public DateTime StartDateTime { get; set; } 
        public DateTime EndDateTime { get; set; }

        public int Value { get; set; }


        public Card()
        {
        }

    }
}
