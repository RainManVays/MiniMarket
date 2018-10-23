using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;


namespace MiniMarket.Context
{
    public class CategoryContext :DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MiniMarket;Trusted_Connection=True;");
            }
        }
    }
}
