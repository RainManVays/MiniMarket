using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MiniMarket.Context;

namespace MiniMarket.Infrastructure
{
    public static class AddDBContexts
    {
        public static void AddDbCont(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<CategoryContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MiniMarketDB")));
            services.AddDbContext<ProductContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MiniMarketDB")));
            services.AddDbContext<UserContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MiniMarketDB")));
            services.AddDbContext<StockContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MiniMarketDB")));
            services.AddDbContext<DeliveryAreaContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MiniMarketDB")));
            services.AddDbContext<AddressContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MiniMarketDB")));
            services.AddDbContext<OrderContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("MiniMarketDB")));
        }
    }
}
