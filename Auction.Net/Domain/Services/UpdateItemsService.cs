using Domain.Interfaces.RepositoryInterfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;

namespace Domain.Services
{
    public class UpdateItemsService : IUpdateItemsService
    {
        private readonly IItemsRepository _itemsRepository;

        public UpdateItemsService(IItemsRepository itemsRepository)
        {
            _itemsRepository = itemsRepository;
        }

        public Task<ItemModel?> changeItem(ItemModel item)
        {
            return _itemsRepository.changeItem(item);
        }

        public Task<ItemModel?> CreateNewItem(ItemModel newItem)
        {
            return _itemsRepository.CreateNewItem(newItem);
        }

        public Task<string> DeleteItem(int idItem)
        {
            return _itemsRepository.DeleteItem(idItem);
        }

        public Task<List<ItemModel>?> GetAllItems()
        {
            return _itemsRepository.GetAllItems();
        }

        public Task<ItemModel?> GetItemsById(int idItem)
        {
            return _itemsRepository.GetItemsById(idItem);
        }

        public Task<List<ItemModel>?> GetItemsByAuction(int idAuction)
        {
            return _itemsRepository.GetItemsByAuction(idAuction);
        }
    }
}
