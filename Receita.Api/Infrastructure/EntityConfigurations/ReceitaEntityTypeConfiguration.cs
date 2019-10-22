using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Receita.Api.Infrastructure.EntityConfigurations
{
    class ReceitaEntityTypeConfiguration : IEntityTypeConfiguration<Model.Receita>
    {
        public void Configure(EntityTypeBuilder<Model.Receita> builder)
        {
            builder.ToTable("Receita");

            builder.HasKey(ci => ci.Id);

            builder.Property(ci => ci.Titulo)
                .IsRequired(true)
                .HasMaxLength(150);

            builder.Property(ci => ci.Descricao)
                .IsRequired(true)
                .HasMaxLength(150);

            builder.Property(ci => ci.Ingredientes)
                .IsRequired(true)
                .HasMaxLength(150);

            builder.Property(ci => ci.ModoPreparo)
                .IsRequired(true)
                .HasMaxLength(150);

            builder.HasOne(ci => ci.Categoria)
                .WithMany(g => g.Receitas)
                .HasForeignKey(ci => ci.IdCategoria);

        }
    }
}
