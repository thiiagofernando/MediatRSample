using MediatRSample.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace MediatRSample.Data
{
    public class AplicacaoDbContext : DbContext
    {
        public AplicacaoDbContext(DbContextOptions<AplicacaoDbContext> options) : base(options) { }

        public DbSet<Pessoa> pessoa { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            foreach (var property in modelBuilder.Model.GetEntityTypes()
                      .SelectMany(e => e.GetProperties()
                          .Where(p => p.ClrType == typeof(string))))
                            {
                                property.SetColumnType("varchar(100)");
                            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AplicacaoDbContext).Assembly);

            base.OnModelCreating(modelBuilder);
        }

    }
}
