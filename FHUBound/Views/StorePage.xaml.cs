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
            Cards.Add(new Card() {
                HeaderTitle = "Study Abroad Pamphlet",
                ImageUrl = "study_abroad_2.png",
                ButtonText = "Buy (500 points)"
            });
            Cards.Add(new Card() {
                HeaderTitle = "FHU Bookstore Coupon",
                ImageUrl = "fhu_color_belltower.png",
                ButtonText = "Buy (1000 points)"
            });


            CardsCollectionView.ItemsSource = Cards;

        }
    }
}
