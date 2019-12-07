using FHUBound.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace FHUBound.Models
{
    public class StoreItem : BaseViewModel
    {

        private string imageUrl;
        public string ImageUrl
        {
            get { return imageUrl; }
            set { SetProperty(ref imageUrl, value); }
        }

        private string name;
        public string Name
        {
            get { return name; }
            set { SetProperty(ref name, value); }
        }

        private int cost;
        public int Cost
        { 
            get { return cost; }
            set { SetProperty(ref cost, value); }
        }

        private string clickEvent;

        public string ClickEvent
        {
            get { return clickEvent; }
            set { SetProperty(ref clickEvent, value);  }
        }







    }
}
