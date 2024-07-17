using Microsoft.EntityFrameworkCore;
using SimpleBanking.Persistence;
namespace SimpleBanking.Extensions
{
    public static class ServiceExtensions
    {
        public static void RegisterSQLDbContext(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContextPool<SimpleBankingDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}