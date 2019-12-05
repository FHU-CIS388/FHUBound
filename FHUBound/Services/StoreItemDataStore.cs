    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FHUBound.Models;

namespace FHUBound.Services
{
    class StoreItemDataStore : IDataStore<StoreItem>
    {
        readonly List<StoreItem> items;
        public StoreItemDataStore()
        {
            items = new List<StoreItem>()
            {
                new StoreItem { Name = "Freed Hardeman T-Shirt!", Description = "It's a Freed Hardeman T-Shirt", ImageURL = "freedtshirt.jpg", Price = 25 },
                new StoreItem { Name = "Freed Hardeman Toy Lion!", Description = "Toy Lion Straigh from Freed!", ImageURL = "freedlionstuffed.jpg", Price = 50 },
                new StoreItem { Name = "David Shannon's Mustache!", Description = "A Mustache Straight from David Shannon Himself!", ImageURL = "toymustache.jpg", Price = 100 }
               
            };
        }
        public async Task<bool> AddItemAsync(StoreItem item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((StoreItem arg) => arg.Name == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<StoreItem> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Name == id));
        }

        public async Task<IEnumerable<StoreItem>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        public async Task<bool> UpdateItemAsync(StoreItem item)
        {
            var oldItem = items.Where((StoreItem arg) => arg.Name == item.Name).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }
    }
}
