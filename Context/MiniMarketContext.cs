using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MiniMarket.Models;

namespace MiniMarket.Context
{
    public partial class MiniMarketContext : DbContext
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
