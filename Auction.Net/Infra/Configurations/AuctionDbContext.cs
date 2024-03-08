﻿using Entities.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infra.Configurations
{
    public class AuctionDbContext : DbContext
    {
        public DbSet<AuctionModel> Auctions { get; set; }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<OfferModel> Offers { get; set; }
        public DbSet<ItemModel> Items { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\deividson\\Documents\\Nova pasta\\100DiasDeCodigo_CSharp\\DataBase\\leilaoDBNLW.db");
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