using leilao.api.Entities;
using leilao.api.Interfaces;
using leilao.api.Repositorios;
using Microsoft.EntityFrameworkCore;


namespace leilao.api.CasosDeUso.Ofertas.GerenciarOfertas
{
    public class AtualizrGerenciarOfertasCasosDeUso : IAtualizarGerenciarOfertasCasosDeUso
    {
        private readonly LeilaoDbContext _leilaoDbContext = new();


        public async Task<List<OfertaModel>?> GetAllOffers()
        {
            try
            {
                return await _leilaoDbContext
                    .Offers
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<OfertaModel>?> getAllOfferById(int id)
        {
            try
            {
                return await _leilaoDbContext
                    .Offers
                    .Where(offer => offer.Id == id)
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<OfertaModel>?> getAllOffersByItem(int idItem)
        {
            try
            {
                return await _leilaoDbContext
                    .Offers
                    .Where(offer => offer.ItemId == idItem)
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<OfertaModel>?> getAllOffersByUser(int idUser)
        {
            try
            {
                return await _leilaoDbContext
                    .Offers
                    .Where(offer => offer.UserId == idUser)
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<OfertaModel>?> GetOffersByUserByItem(int idUser, int idItem)
        {
            try
            {
                return await _leilaoDbContext
                    .Offers
                    .Where(offer => offer.UserId == idUser && offer.ItemId == idItem)
                    .ToListAsync();
            }
            catch
            {
                return null;
            }
        }

        public async Task<OfertaModel?> GetMaiorOfferByItem(int idItem)
        {
            try
            {
                using(var banco = _leilaoDbContext)
                {
                    return await
                        (
                        from o in banco.Offers
                        where o.ItemId == idItem
                        orderby -((double)o.Price)
                        select o).AsNoTracking().FirstOrDefaultAsync();
                }

            }
            catch
            {
                return null;
            }
        }

        public async Task<List<OfertaModel>?> GetOffersInLeiloesAtivos()
        {
            try
            {
                using (var banco = _leilaoDbContext)
                {
                    return await
                        (from o in banco.Offers
                         join i in banco.Items on o.ItemId equals i.Id
                         join l in banco.Auctions on i.AuctionId equals l.Id
                         where l.Starts <= DateTime.Now && l.Ends >= DateTime.Now
                         select o).AsNoTracking().ToListAsync();
                }
            }
            catch
            {
                return null;
            }
        }

        public async Task<List<OfertaModel>?> GetOffersInLeiloesEncerrados()
        {
            
            try
            {
                using (var banco = _leilaoDbContext)
                {
                    return await 
                        (from o in banco.Offers
                         join i in banco.Items on o.ItemId equals i.Id
                         join l in banco.Auctions on i.AuctionId equals l.Id
                         where l.Ends < DateTime.Now
                         select o).AsNoTracking().ToListAsync();
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
