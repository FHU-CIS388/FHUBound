using System;
namespace FHUBound.Models
{
    public class Card
    {
        public string HeaderTitle { get; set; }
        public string HeaderSubtitle { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }

        public string ButtonUrl { get; set; }
        public string ButtonText { get; set; }

        public string BodyTitle { get; set; }
        public string BodySubtitle { get; set; }
        public string BodyContent { get; set; }

        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }

        public Card()
        {
        }

    }
}
