using leilao.api.Entities;
using leilao.api.Repositorios;
using Microsoft.AspNetCore.Http.HttpResults;

namespace leilao.api.CasosDeUso.Items
{
    public class AtualizarItemsCasosDeUso
    {
        private readonly LeilaoDbContext _leilaoDbContext = new();

        public List<ItemModel>? GetAllItems()
        {
            try
            {
                return _leilaoDbContext
                    .Items
                    .ToList();
            }
            catch
            {
                return null;
            }
        }
        public List<ItemModel>? GetItemsByLeilao(int idLeilao) 
        {
            try
            {
                return _leilaoDbContext
                    .Items
                    .Where(item => item.AuctionId == idLeilao)
                    .ToList();
            }
            catch
            {
                return null;
            }
        }
        public ItemModel? GetItemsById(int idItem) 
        {
            try
            {
                return _leilaoDbContext
                    .Items
                    .Where(item => item.Id == idItem)
                    .FirstOrDefault();
            }
            catch
            {
                return null;
            }
        }
        public ItemModel? CreateNewItem(ItemModel novoItem)
        {
            try
            {
                _leilaoDbContext.Items.Add(novoItem);
                _leilaoDbContext.SaveChanges();
                return novoItem;
            }
            catch
            {
                return null;
            }
        }

        public ItemModel? AlterarItem(ItemModel item)
        {
            var result = _leilaoDbContext.Items.FirstOrDefault(i => i.AuctionId == item.AuctionId && i.Id == item.Id);
            if (result == null) return null;
            try
            {
                result.Name = item.Name;
                result.Condition = item.Condition;
                result.Brand = item.Brand;
                result.BasePrice = item.BasePrice;

                _leilaoDbContext.Items.Update(result);
                _leilaoDbContext.SaveChanges();
                
                return result;
            }
            catch
            {
                return null;
            }
        }

        public string DeleteItem( int idItem)
        {
            var result = _leilaoDbContext.Items.FirstOrDefault(i => i.Id == idItem);
            if (result == null) return "Nao encontrado";
            try
            {
                _leilaoDbContext.Items.Remove(result);
                _leilaoDbContext.SaveChanges();
                return "Sucesso";
            }
            catch
            {
                return "Falha";
            }
        }
    }
}
