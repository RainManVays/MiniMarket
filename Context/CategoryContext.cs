using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;


namespace MiniMarket.Context
{
    public class CategoryContext :DbContext
    {
        public virtual DbSet<Category> Categories { get; set; }
        
        public CategoryContext(DbContextOptions<CategoryContext> options) : base(options)
        {

        }
    }
}
