using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using FHUBound.Models;
using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class StorePage : ContentPage
    {
        public ObservableCollection<Card> Cards { get; set; }
        public StorePage()
        {
            InitializeComponent();

            Cards = new ObservableCollection<Card>();
            Cards.Add(new Card() { HeaderTitle = "Sticker Pack", ImageUrl = "stickers.jpg", Value = 1000 });
            Cards.Add(new Card() { HeaderTitle = "Poster", ImageUrl = "poster.jpg", Value = 1000 });
            Cards.Add(new Card() { HeaderTitle = "Lions hat", ImageUrl = "hat.jpg", Value = 2500 });
            Cards.Add(new Card() { HeaderTitle = "Lions Phone Pocket", ImageUrl = "phone_pocket.jpg", Value = 2500 });
            Cards.Add(new Card() { HeaderTitle = "Lions T-Shirt", ImageUrl = "lions_t.jpg", Value = 5000 });
            Cards.Add(new Card() { HeaderTitle = "FHUBound T-Shirt", ImageUrl = "bound_t.png", Value = 5000 });
            Cards.Add(new Card() { HeaderTitle = "Lions Hoodie", ImageUrl = "lions_hoodie.jpg", Value = 10000 });
            Cards.Add(new Card() { HeaderTitle = "FHU Hoodie", ImageUrl = "fhu_hoodie.jpg", Value = 10000 });
            Cards.Add(new Card() { HeaderTitle = "David Shannon Plushie", ImageUrl = "ds.jpeg", Value = 20000 });


            ShopCollectionView.ItemsSource = Cards;
        }

        async void OnAlertYesNoClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Confirm BoundBuck Transaction", "Is your information in order?" + Environment.NewLine + Environment.NewLine + "David Shannon" + Environment.NewLine + Environment.NewLine + "7707 Greene Farm Ct." + Environment.NewLine + "Ypsilanti, MI 48197", "Yes, send my prize!", "Nevermind");
            Debug.WriteLine("Answer: " + answer);
        }
    }
}
