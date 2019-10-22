using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Receita.Api.Model;

namespace Receita.Api.Infrastructure.EntityConfigurations
{
    class CategoriaEntityTypeConfiguration : IEntityTypeConfiguration<Model.Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("Categoria");

            builder.Property(ci => ci.Id);

            builder.Property(ci => ci.Titulo)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Property(ci => ci.Descricao)
                .IsRequired(true)
                .HasMaxLength(150);
        }
    }
}
