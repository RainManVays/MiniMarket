using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;

namespace MiniMarket.Context
{
    public class StockContext : DbContext
    {

        public virtual DbSet<Stock> Stocks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MiniMarket;Trusted_Connection=True;");
            }
        }

    }
}
