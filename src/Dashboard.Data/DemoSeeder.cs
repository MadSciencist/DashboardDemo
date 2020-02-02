#region copyright
// All rights reserved 
// Mateusz Kryszczak 2020
#endregion
using Dashboard.Domain;
using Dashboard.Domain.Entities;
using Dashboard.Domain.Repository;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Dashboard.Data
{
    public class DemoSeeder
    {
        public static async Task SeedAsync(IServiceProvider sp)
        {
            using var scope = sp.CreateScope();
            var config = scope.ServiceProvider.GetRequiredService<IConfiguration>();

            var useInMemoryStore = config.GetValue<bool>("Data:UseInMemoryStore");
            if (!useInMemoryStore) return;

            var repo = scope.ServiceProvider.GetRequiredService<IUiNodeRepository>();

            foreach (var node in GetNodes())
            {
                await repo.AddNode(node);
            }
        }

        private static IEnumerable<UiNode> GetNodes()
        {
            return new List<UiNode>
            {
                new UiNode
                {
                    Id = 1,
                    ParentId = 0,
                    Type = UiNodeType.PageScope,
                    Name = "Home Page",
                    Data = "{}"
                },
                new UiNode
                {
                    Id = 2,
                    ParentId = 2,
                    Type = UiNodeType.DashboardScope,
                    Name = "Main View",
                    Data = "{}"
                }
            };
        }
    }
}
