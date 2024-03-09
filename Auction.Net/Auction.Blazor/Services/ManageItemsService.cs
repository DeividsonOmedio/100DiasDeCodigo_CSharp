using Auction.Blazor.Services.Interfaces;
using Entities.Entities;

namespace Auction.Blazor.Services
{
    public class ManageItemsService : IManageItemsService
    {
        public Task<ItemModel?> changeItem(ItemModel item)
        {
            throw new NotImplementedException();
        }

        public Task<ItemModel?> CreateNewItem(ItemModel newItem)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeleteItem(int idItem)
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemModel>?> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Task<List<ItemModel>?> GetItemsByAuction(int idAuction)
        {
            throw new NotImplementedException();
        }

        public Task<ItemModel?> GetItemsById(int idItem)
        {
            throw new NotImplementedException();
        }
    }
}
