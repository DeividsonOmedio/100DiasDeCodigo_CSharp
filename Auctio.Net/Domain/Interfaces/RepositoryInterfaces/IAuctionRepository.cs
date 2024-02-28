﻿using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces.RepositoryInterfaces
{
    public interface IAuctionRepository
    {
        Task<List<AuctionModel>?> GetAll();
        Task<AuctionModel?> GetById(int id);
        Task<List<AuctionModel>?> GetByName(string name);
        Task<List<AuctionModel>?> GetCurrent();
        Task<List<AuctionModel>?> GetByDate(DateTime data);
        Task<List<AuctionModel>?> GetByPeriodo(DateTime dataInicial, DateTime dataFinal);
        Task<List<AuctionModel>?> GetByAtivos();
        Task<List<AuctionModel>?> GetByProgramados();
        Task<List<AuctionModel>?> GetByEncerrados();
        Task<AuctionModel> InserirNovoLeilao(AuctionModel novoLeilao);
        Task<AuctionModel?> AlterarLeilao(int id, AuctionModel leilao);
        Task<string> DeletarLeilao(int id);
    }
}
