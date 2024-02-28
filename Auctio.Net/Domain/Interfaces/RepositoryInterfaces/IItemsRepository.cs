using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.RepositoryInterfaces
{
    public interface IItemsRepository
    {
        List<ItemModel>? GetAllItems();
        List<ItemModel>? GetItemsByLeilao(int idAuction);
        ItemModel? GetItemsById(int idItem);
        ItemModel? CreateNewItem(ItemModel newItem);
        ItemModel? changeItem(ItemModel item);
        string DeleteItem(int idItem);

    }
}
