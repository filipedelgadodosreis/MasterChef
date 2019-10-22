using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Receita.Api.Infrastructure.EntityConfigurations;

namespace Receita.Api.Infrastructure
{
    public class ReceitaContext : DbContext
    {
        public ReceitaContext(DbContextOptions<ReceitaContext> options) : base(options) { }

        public DbSet<Model.Receita> Receitas { get; set; }
        public DbSet<Model.Categoria> Categorias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ReceitaEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new CategoriaEntityTypeConfiguration());
        }

    }

    public class ReceitaContextDesignFactory : IDesignTimeDbContextFactory<ReceitaContext>
    {
        public ReceitaContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ReceitaContext>()
                    .UseSqlServer("Server=.\\SQLExpress;Initial Catalog=CulinariaDb;Integrated Security=true");

            return new ReceitaContext(optionsBuilder.Options);
        }
    }
}
