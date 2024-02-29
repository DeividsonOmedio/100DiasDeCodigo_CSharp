using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using Infra.Configurations;
using Microsoft.EntityFrameworkCore;

namespace Infra.Repository
{
    public class ItemsRepository : IItemsRepository
    {
        private readonly AuctionDbContext _auctionDbContext;

        public ItemsRepository(AuctionDbContext auctionDbContext) => _auctionDbContext = auctionDbContext;

        public async Task<List<ItemModel>?> GetAllItems()
        {
            try
            {
                return await _auctionDbContext
                    .Items
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }
        public async Task<ItemModel?> GetItemsById(int idItem)
        {
            try
            {
                return await _auctionDbContext
                    .Items
                    .Where(item => item.Id == idItem)
                    .FirstOrDefaultAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<ItemModel>?> GetItemsByAuction(int idAuction)
        {
            try
            {
                return await _auctionDbContext
                    .Items
                    .Where(item => item.AuctionId == idAuction)
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<ItemModel?> CreateNewItem(ItemModel newItem)
        {
            try
            {
                await _auctionDbContext.Items.AddAsync(newItem);
                await _auctionDbContext.SaveChangesAsync();
                return newItem;
            }
            catch
            {
                return null;
            }
        }

        public async Task<ItemModel?> changeItem(ItemModel item)
        {
            var result = await _auctionDbContext.Items.FirstOrDefaultAsync(i => i.AuctionId == item.AuctionId && i.Id == item.Id);
            if (result == null) return null;
            try
            {
                result.Name = item.Name;
                result.Condition = item.Condition;
                result.Brand = item.Brand;
                result.BasePrice = item.BasePrice;

                _auctionDbContext.Items.Update(result);
                await _auctionDbContext.SaveChangesAsync();

                return result;
            }
            catch
            {
                return null;
            }
        }

        public async Task<string> DeleteItem(int idItem)
        {
            var result = await _auctionDbContext.Items.FirstOrDefaultAsync(i => i.Id == idItem);
            if (result == null) return "Nao encontrado";
            try
            {
                _auctionDbContext.Items.Remove(result);
                await _auctionDbContext.SaveChangesAsync();
                return "Sucesso";
            }
            catch
            {
                return "Falha";
            }
        }

    }
}
