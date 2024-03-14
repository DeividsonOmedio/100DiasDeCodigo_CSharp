using Entities.Entities;

namespace Auction.Blazor.Services.Interfaces
{
    public interface IManageItemsService
    {
        Task<IEnumerable<ItemModel>?> GetAllItems();
        Task<IEnumerable<ItemModel>?> GetItemsByAuction(int idAuction);
        Task<ItemModel?> GetItemById(int idItem);
        Task<ItemModel?> CreateNewItem(int idAuction, ItemModel newItem);
        Task<ItemModel?> ChangeItem(int idItem, ItemModel item);
        Task<string?> DeleteItem(int idItem);
    }
}
