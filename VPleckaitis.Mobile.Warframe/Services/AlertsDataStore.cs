using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using VPleckaitis.Mobile.Warframe.Models;
using VPleckaitis.Mobile.Warframe.Models.External;

namespace VPleckaitis.Mobile.Warframe.Services
{
    public class AlertsDataStore : IDataStore<Alert>
    {
        private const string dataUrl = "rss.php";
        List<Alert> items;

        public AlertsDataStore()
        {
            var content = Helpers.HttpClientEx.Client.GetAsync(dataUrl).GetAwaiter().GetResult();

            var lst = content.Map<List<RssFeedModel>>();

            items = new List<Alert>()
            {
                new Alert { Id = Guid.NewGuid().ToString(), Title = "First item", Description="This is an item description." },
                new Alert { Id = Guid.NewGuid().ToString(), Title = "Second item", Description="This is an item description." },
                new Alert { Id = Guid.NewGuid().ToString(), Title = "Third item", Description="This is an item description." },
                new Alert { Id = Guid.NewGuid().ToString(), Title = "Fourth item", Description="This is an item description." },
                new Alert { Id = Guid.NewGuid().ToString(), Title = "Fifth item", Description="This is an item description." },
                new Alert { Id = Guid.NewGuid().ToString(), Title = "Sixth item", Description="This is an item description." }
            };
        }

        public async Task<bool> AddItemAsync(Alert item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Alert item)
        {
            var oldItem = items.Where((Alert arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Alert arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Alert> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Alert>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}