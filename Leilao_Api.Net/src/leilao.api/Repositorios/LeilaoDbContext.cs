using leilao.api.Entities;
using Microsoft.EntityFrameworkCore;

namespace leilao.api.Repositorios
{
    public class LeilaoDbContext : DbContext
    {
        public DbSet<LeilaoModel> Auctions { get; set; }
        public DbSet<UsuarioModel> Users { get; set; }
        public DbSet<OfertaModel> Offers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=C:\\Users\\deividson\\Downloads\\leilaoDbNLW.db");
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
