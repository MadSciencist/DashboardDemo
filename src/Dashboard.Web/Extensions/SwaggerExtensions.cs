#region copyright
// All rights reserved 
// Mateusz Kryszczak 2020
#endregion
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Dashboard.Web.Extensions
{
    public static class SwaggerExtensions
    {
        public static void AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                var contact = new OpenApiContact { Email = "mkrysz1337@gmail.com", Name = "Mateusz" };
                options.SwaggerDoc("v1", new OpenApiInfo { Title = "Dashboard Demo", Version = "v1", Contact = contact });
            });
        }
    }
}
