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

        }
    }
}
