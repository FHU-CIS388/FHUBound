using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using FHUBound.Models;
using FHUBound.ViewModels;
using Xamarin.Forms;

namespace FHUBound.Views
{
    public partial class StorePage : ContentPage
    {
        public ObservableCollection<StoreItem> StoreItems { get; set; }

        public StorePage()
        {
            InitializeComponent();
            BindingContext = new StoreViewModel();
            

            
        }
    }
}
