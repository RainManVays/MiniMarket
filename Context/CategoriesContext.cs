using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniMarket.Context
{
    public class CategoriesContext :DbContext
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
