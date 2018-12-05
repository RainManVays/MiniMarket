using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;

namespace MiniMarket.Context
{
    public class ProductContext :DbContext
    {

        public virtual DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {

        }

    }
}
