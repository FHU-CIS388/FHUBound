using FHUBound.Models;
using FHUBound.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FHUBound.ViewModels
{
    class StoreViewModel : BaseViewModel



    {

        public ObservableCollection<StoreItem> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public StoreDataStore DataStore = new StoreDataStore();
        public bool IsBusy { get; private set; }

        public StoreViewModel()
        {
            Title = "Store";
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            Items = new ObservableCollection<StoreItem>();

        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var storeitems = await DataStore.GetItemsAsync(true);
                foreach (var item in storeitems)
                {
                    Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }





    }
}
