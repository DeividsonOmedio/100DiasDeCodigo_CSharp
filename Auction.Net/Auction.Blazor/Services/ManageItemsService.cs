using Auction.Blazor.Services.Interfaces;
using Entities.Entities;
using System.Net.Http.Json;

namespace Auction.Blazor.Services
{
    public class ManageItemsService(HttpClient httpClient) : IManageItemsService
    {
        public HttpClient _httpClient = httpClient;

        public async Task<IEnumerable<ItemModel>?> GetAllItems() => await _httpClient.GetFromJsonAsync<IEnumerable<ItemModel>>("Items/GetAllItems");
  
        public async Task<IEnumerable<ItemModel>?> GetItemsByAuction(int idAuction) => await _httpClient.GetFromJsonAsync<IEnumerable<ItemModel>>($"Items/ItemsByLeilao/{idAuction}");

        public async Task<ItemModel?> GetItemById(int idItem) => await _httpClient.GetFromJsonAsync<ItemModel>("Items/GetAllItems");

        public async Task<ItemModel?> CreateNewItem(int idAuction, ItemModel newItem)
        {
            var response = await _httpClient.PostAsJsonAsync<ItemModel>($"Items/CreateNewItem/{idAuction}", newItem);
            return await response.Content.ReadFromJsonAsync<ItemModel>();
        }
        
        public async Task<ItemModel?> ChangeItem(int idItem,ItemModel item)
        {
            var response = await _httpClient.PatchAsJsonAsync<ItemModel>($"Items/{idItem}", item);
            return await response.Content.ReadFromJsonAsync<ItemModel>();
        }

        public async Task<string?> DeleteItem(int idItem)
        {
            var response = await _httpClient.DeleteAsync($"Items/DeleteItem/{idItem}");
            return response.Content.ToString();
        }
    }
}
