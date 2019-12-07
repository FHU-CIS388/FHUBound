using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using FHUBound.Models;
using FHUBound.Services;
using System.ComponentModel;
using System.Windows.Input;
using System.Threading.Tasks;

namespace FHUBound.ViewModels
{
    
    class StoreViewModel: BaseViewModel
    {
        public User User { get; set; }

        public ObservableCollection<StoreItem> StoreItems { get; set; }

        public StoreViewModel()
        {
            User = App.CurrentUser;
            StoreItems = new ObservableCollection<StoreItem>();
            StoreItems.Add(new StoreItem() { ItemName = "T-Shirt", ImageUrl = "shirt1.png", Price = 500 });
            StoreItems.Add(new StoreItem() { ItemName = "Hoodie", ImageUrl = "hoodie.jpg", Price = 1000 });
            StoreItems.Add(new StoreItem() { ItemName = "Lion Plushie", ImageUrl = "lionPlush.jpg", Price = 1500 });
        }
        public ICommand StoreButtonPress
        {
            get
            {
                return new Command((s) =>
                {
                    var sItem = s as StoreItem;
                    int? points = sItem.Price as int?;
                    User.TotalPoints -= points.Value;
                }
                );
            }
        }
    }
}
