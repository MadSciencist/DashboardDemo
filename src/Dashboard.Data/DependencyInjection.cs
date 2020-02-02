#region copyright
// All rights reserved 
// Mateusz Kryszczak 2020
#endregion
using Dashboard.Data.Repository;
using Dashboard.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Dashboard.Data
{
    public static class DependencyInjection
    {
        public static void AddDataAccessLayer(this IServiceCollection services, IConfiguration configuration)
        {
            var useInMemoryStore = configuration.GetValue<bool>("Data:UseInMemoryStore");

            if (useInMemoryStore)
            {
                services.AddDbContext<EfContext>(options =>
                {
                    options.UseInMemoryDatabase("InMemoryDb");
                    options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                }, ServiceLifetime.Transient);
            }
            else
            {
                throw new NotImplementedException();
            }

            AddRepositories(services);
        }

        private static void AddRepositories(IServiceCollection services)
        {
            services.AddTransient<IUiNodeRepository, UiNodeRepository>();
        }
    }
}
