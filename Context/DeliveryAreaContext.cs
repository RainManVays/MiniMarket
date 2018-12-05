using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;

namespace MiniMarket.Context
{
    public class DeliveryAreaContext : DbContext
    {
        public virtual DbSet<DeliveryArea> DeliveryAreas { get; set; }

        public DeliveryAreaContext(DbContextOptions<DeliveryAreaContext> options) : base(options)
        {

        }
    }
}
