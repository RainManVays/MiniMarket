using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;

namespace MiniMarket.Context
{
    public class OrderContext : DbContext
    {
        public virtual DbSet<OrderDB> Orders { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {

        }
    }
}
