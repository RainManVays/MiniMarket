using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;

namespace MiniMarket.Context
{
    public class UserContext:DbContext
    {
        public virtual DbSet<User> Users { get; set; }

        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }
    }
}
