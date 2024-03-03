﻿using Domain.Interfaces.RepositoryInterfaces;
using Domain.Interfaces.ServicesInterfaces;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class UpdateAuctionService : IUpdateAuctionService
    {
        private readonly IAuctionRepository _auctionRepository;

        public UpdateAuctionService(IAuctionRepository auctionRepository) =>
            _auctionRepository = auctionRepository;

        public Task<AuctionModel?> ChangeAuction(int id, AuctionModel leilao) =>
            _auctionRepository.ChangeAuction(id, leilao);


        public Task<AuctionModel> CreateNewAuction(AuctionModel novoLeilao) =>
            _auctionRepository.CreateNewAuction(novoLeilao);

        public Task<string> DeleteAuction(int id) =>
            _auctionRepository.DeleteAuction(id);

        public Task<List<AuctionModel>?> GetCurrent() =>
            _auctionRepository.GetCurrent();

        public Task<List<AuctionModel>?> GetByActives() =>
            _auctionRepository.GetByActives();

        public Task<List<AuctionModel>?> GetByClosed() =>
            _auctionRepository.GetByClosed();

        public Task<List<AuctionModel>?> GetByDate(DateTime date) =>
            _auctionRepository.GetByDate(date);

        public Task<AuctionModel?> GetById(int id) =>
            _auctionRepository.GetById(id);

        public Task<List<AuctionModel>?> GetByName(string name) =>
            _auctionRepository.GetByName(name);

        public Task<List<AuctionModel>?> GetByPeriod(DateTime dateStart, DateTime dateFinish) =>
            _auctionRepository.GetByPeriod(dateStart, dateFinish);

        public Task<List<AuctionModel>?> GetByProgrammed() =>
            _auctionRepository.GetByProgrammed();
    }
}
