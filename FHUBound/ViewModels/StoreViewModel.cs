using FHUBound.Models;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.Generic;
using System.Diagnostics;
using FHUBound.ViewModels;

namespace FHUBound.ViewModels
{
    public class StoreViewModel : BaseViewModel
    {
        public User User { get; set; }
        public ObservableCollection<Card> StoreItemCards { get; set; }
        public StoreViewModel()
        {
            System.Console.WriteLine("Store View Model Started");
            User = App.CurrentUser;
            StoreItemCards = new ObservableCollection<Card>();
            StoreItemCards.Add(new Card() { HeaderTitle = "Sticker Pack", ImageUrl = "stickers.jpg", Value = 1000 });
            StoreItemCards.Add(new Card() { HeaderTitle = "Poster", ImageUrl = "poster.jpg", Value = 1000 });
            StoreItemCards.Add(new Card() { HeaderTitle = "Lions hat", ImageUrl = "hat.jpg", Value = 2500 });
            StoreItemCards.Add(new Card() { HeaderTitle = "Lions Phone Pocket", ImageUrl = "phone_pocket.jpg", Value = 2500 });
            StoreItemCards.Add(new Card() { HeaderTitle = "Lions T-Shirt", ImageUrl = "lions_t.jpg", Value = 5000 });
            StoreItemCards.Add(new Card() { HeaderTitle = "FHUBound T-Shirt", ImageUrl = "bound_t.png", Value = 5000 });
            StoreItemCards.Add(new Card() { HeaderTitle = "Lions Hoodie", ImageUrl = "lions_hoodie.jpg", Value = 10000 });
            StoreItemCards.Add(new Card() { HeaderTitle = "FHU Hoodie", ImageUrl = "fhu_hoodie.jpg", Value = 10000 });
            StoreItemCards.Add(new Card() { HeaderTitle = "David Shannon Plushie", ImageUrl = "ds.jpeg", Value = 20000 });


            //ShopCollectionView.ItemsSource = Cards;
        }
        public ICommand RemoveBucks
        {
            get
            {
                return new Command((value) =>
                {
                    int? intValue = value as int?;
                    if (intValue != null)
                    {
                        User.CurrentPoints -= intValue.Value;
                    }
                });
            }
        }
        public ICommand AlertPopUp
        {
            get
            {
                return new Command(async (value) =>
                {
                    bool answer = await App.Current.MainPage.DisplayAlert("Confirm BoundBuck Transaction", "Is your information in order?" + Environment.NewLine + Environment.NewLine + "David Shannon" + Environment.NewLine + Environment.NewLine + "7707 Greene Farm Ct." + Environment.NewLine + "Ypsilanti, MI 48197", "Yes, send my prize!", "Nevermind");
                    if (answer == true)
                    {
                        int? intValue = value as int?;
                        if (intValue<= User.CurrentPoints)
                        {
                            RemoveBucks.Execute(intValue);
                        }
                        else
                        {
                            bool alertNoteEnoughBucks = await App.Current.MainPage.DisplayAlert("Sorry!", "You don't have enough BoundBucks to redeem this item. :(", null, "Okay, Got it!");
                        }
                        
                    }
                });
            }
        }
    }
}