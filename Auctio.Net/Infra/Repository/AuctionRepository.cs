using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class AuctionRepository : IAuctionRepository
    {
        public Task<AuctionModel?> AlterarLeilao(int id, AuctionModel leilao)
        {
            throw new NotImplementedException();
        }

        public Task<string> DeletarLeilao(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuctionModel>?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<List<AuctionModel>?> GetByAtivos()
        {
            throw new NotImplementedException();
        }

        public Task<List<AuctionModel>?> GetByDate(DateTime data)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuctionModel>?> GetByEncerrados()
        {
            throw new NotImplementedException();
        }

        public Task<AuctionModel?> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuctionModel>?> GetByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuctionModel>?> GetByPeriodo(DateTime dataInicial, DateTime dataFinal)
        {
            throw new NotImplementedException();
        }

        public Task<List<AuctionModel>?> GetByProgramados()
        {
            throw new NotImplementedException();
        }

        public Task<List<AuctionModel>?> GetCurrent()
        {
            throw new NotImplementedException();
        }

        public Task<AuctionModel> InserirNovoLeilao(AuctionModel novoLeilao)
        {
            throw new NotImplementedException();
        }
    }
}
