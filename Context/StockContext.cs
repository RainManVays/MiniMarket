using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;

namespace MiniMarket.Context
{
    public class StockContext : DbContext
    {

        public virtual DbSet<Stock> Stocks { get; set; }

        public StockContext(DbContextOptions<StockContext> options) : base(options)
        {

        }

    }
}
