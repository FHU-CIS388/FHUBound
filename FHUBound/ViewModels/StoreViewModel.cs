using FHUBound.Models;
using System.Collections.ObjectModel;
using Xamarin.Forms;

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
    }
}