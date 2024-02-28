using Domain.Interfaces.RepositoryInterfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infra.Repository
{
    public class CreateOfferRepository : ICreateOfferRepository
    {
        public Task<OfferModel> Execute(int itemId, RequisicaoCriarOferta request)
        {
            throw new NotImplementedException();
        }
    }
}
