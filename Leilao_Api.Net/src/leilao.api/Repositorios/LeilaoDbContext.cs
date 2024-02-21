﻿using leilao.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace leilao.api.Repositorios
{
    public class LeilaoDbContext : DbContext
    {
        public DbSet<LeilaoModel> Auctions { get; set; }
        public DbSet<UsuarioModel> Users { get; set; }
        public DbSet<OfertaModel> Offers { get; set; }
        public DbSet<ItemModel> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\deividson\\Documents\\110DayCode\\100DiasDeCodigo_CSharp\\DataBase\\leilaoDBNLW.db");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemModel>()
                .HasOne(item => item.Auction)
                .WithMany(auction => auction.Items)
                .HasForeignKey(item => item.AuctionId);
        }
    }
}
