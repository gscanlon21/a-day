using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ADay.Data.Code.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddShared(this IServiceCollection services, IConfiguration configuration, bool migrations = false)
    {
        var sharedContext = configuration.GetConnectionString("SharedContext") ?? throw new InvalidOperationException("Connection string 'SharedContext' not found.");
        services.AddDbContext<SharedContext>(options => options.UseNpgsql(sharedContext, options =>
        {
            options.UseQuerySplittingBehavior(QuerySplittingBehavior.SingleQuery);

            if (migrations)
            {
                options.MigrationsAssembly(typeof(SharedContext).Assembly.GetName().Name);
            }
        }));
    }
}
