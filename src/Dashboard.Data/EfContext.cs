#region copyright
// All rights reserved 
// Mateusz Kryszczak 2020
#endregion
using Dashboard.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Dashboard.Data
{
    public class EfContext : DbContext
    {
        public EfContext(DbContextOptions<EfContext> options) : base(options)
        {
        }

        public DbSet<UiNode> UiNodes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UiNode>()
                .HasKey(x => x.Id);
        }
    }
}
