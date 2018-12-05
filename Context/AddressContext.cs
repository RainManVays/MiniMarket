using Microsoft.EntityFrameworkCore;
using MiniMarket.Models;

namespace MiniMarket.Context
{
    public class AddressContext : DbContext
    {
        public virtual DbSet<Address> Address { get; set; }

        public AddressContext(DbContextOptions<AddressContext> options) : base(options)
        {

        }
    }
}
