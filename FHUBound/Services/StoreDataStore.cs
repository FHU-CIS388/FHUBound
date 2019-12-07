using FHUBound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHUBound.Services
{
    public class StoreDataStore : IDataStore<StoreItem>
    {
        readonly List<StoreItem> items;

        public StoreDataStore()
        {
            items = new List<StoreItem>()
            {
                new StoreItem {ImageUrl = "jacket.png", Name = "Jacket", Cost = 1000, ClickEvent = "jacket_click" },
                new StoreItem {ImageUrl = "better_shirt.png", Name ="Shirt", Cost = 850, ClickEvent = "shirt_click"}, 
                new StoreItem {ImageUrl = "cap.png",Name="Cap" ,Cost=500, ClickEvent = "cap_click"},
                new StoreItem {ImageUrl = "book.png", Name= "FHU book", Cost = 50 , ClickEvent = "book_click"},
                new StoreItem {ImageUrl = "gift.png", Name="Mystery Gift", Cost= 5000 , ClickEvent = "gift_click"},
              
            };
        }

        public async Task<bool> AddItemAsync(StoreItem item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(StoreItem item)
        {
            var oldItem = items.Where((StoreItem arg) => arg.Name == item.Name).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((StoreItem arg) => arg.Name == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<StoreItem> GetItemAsync(string name)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Name == name));
        }

        public async Task<IEnumerable<StoreItem>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}
