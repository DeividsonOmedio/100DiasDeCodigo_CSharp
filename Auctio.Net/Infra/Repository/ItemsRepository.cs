using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class ItemsRepository : IItemsRepository
    {
        public ItemModel? changeItem(ItemModel item)
        {
            throw new NotImplementedException();
        }

        public ItemModel? CreateNewItem(ItemModel newItem)
        {
            throw new NotImplementedException();
        }

        public string DeleteItem(int idItem)
        {
            throw new NotImplementedException();
        }

        public List<ItemModel>? GetAllItems()
        {
            throw new NotImplementedException();
        }

        public ItemModel? GetItemsById(int idItem)
        {
            throw new NotImplementedException();
        }

        public List<ItemModel>? GetItemsByLeilao(int idAuction)
        {
            throw new NotImplementedException();
        }
    }
}
