using Entities.Entities;

namespace Domain.Interfaces.RepositoryInterfaces
{
    public interface IItemsRepository
    {
        Task<List<ItemModel>?> GetAllItems();
        Task<List<ItemModel>?> GetItemsByAuction(int idAuction);
        Task<ItemModel?> GetItemsById(int idItem);
        Task<ItemModel?> CreateNewItem(ItemModel newItem);
        Task<ItemModel?> changeItem(ItemModel item);
        Task<string> DeleteItem(int idItem);

    }
}
