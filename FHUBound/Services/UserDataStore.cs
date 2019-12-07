using FHUBound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FHUBound.Services
{
    public class UserDataStore : IDataStore<User>
    {
        readonly List<User> users;
        public UserDataStore()
        {
            users = new List<User>()
            {
                new User { Id = "1", Name = "John Hopkins", Password = "pirate01"},
                new User { Id = "2", Name = "Amy Dashford", Password = "jonaslover14"},
                new User { Id = "3", Name = "Nemo", ImagePath = "profile.jpg", ADVRegistered = true, MGRegistered = true      }
            };
        }
        public async Task<bool> AddItemAsync(User _user)
        {
            users.Add(_user);
            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {            
            var temp = from user in users
                       where user.Name == id
                       select user;
            users.Remove(temp.FirstOrDefault());
            return await Task.FromResult(true);
        }

        public async Task<User> GetItemAsync(string id)
        {
            return await Task.FromResult(users.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<User>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(users);
        }

        public async Task<bool> UpdateItemAsync(User item)
        {
            var temp = from user in users
                       where user.Name == item.Name
                       select user;
            users.Remove(temp.FirstOrDefault());
            users.Add(item);
            return await Task.FromResult(true);
        }
    }
}
