using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using FHUBound.Models;
using Xamarin.Forms;
using FHUBound.Services;
using System.Threading.Tasks;
using System.Diagnostics;

namespace FHUBound.ViewModels
{
    class StoreViewModel : BaseViewModel
    {
        public ObservableCollection<StoreItem> StoreItems { get; set; }

        public Command LoadItemsCommand { get; set; }

        public StoreItemDataStore DataStore = new StoreItemDataStore();


        public StoreViewModel()
        {
            Title = "FHU Store";
            StoreItems = new ObservableCollection<StoreItem>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());


        }
        private async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;
            IsBusy = true;
            try
            {
                StoreItems.Clear();
                var storeitem = await DataStore.GetItemsAsync(true);
                foreach(var m in storeitem)
                {
                    StoreItems.Add(m);
                }

            }
            catch(Exception ex)
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
    

