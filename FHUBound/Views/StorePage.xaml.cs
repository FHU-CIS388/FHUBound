using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FHUBound.Models;

using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class StorePage : ContentPage
    {
        public ObservableCollection<StoreItem> StoreItems { get; set; }

        public StorePage()
        {
            InitializeComponent();

            StoreItems = new ObservableCollection<StoreItem>();
            StoreItems.Add(new StoreItem() { ItemName = "T-Shirt", ImageUrl = "shirt1.png", Price = 500 });
            StoreItems.Add(new StoreItem() { ItemName = "Hoodie", ImageUrl = "hoodie.jpg", Price = 1000 });
            StoreItems.Add(new StoreItem() { ItemName = "Lion Plushie", ImageUrl = "lionPlush.jpg", Price = 1500 });

            StoreCollectionView.ItemsSource = StoreItems;
        }
    }
}
