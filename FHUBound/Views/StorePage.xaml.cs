using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            Cards.Add(new Card() { HeaderTitle = "Profile Pic", ImageUrl = "fhu_square.jpg", ButtonText = "Change Pic" });
            Cards.Add(new Card()
            {
                HeaderTitle = "Badges Collected",
                BodyTitle = "😃  ❤️  👨🏻‍🦳  🔒  🔒  🔒  🔒  🔒  🔒  🔒  🔒  🔒  🔒  🔒  ",
                BodyContent = "Newest badge: 👨🏻‍🦳 (David Shannon) Collect 100 points"
            });


            CardsCollectionView.ItemsSource = Cards;

        }
    }
}
