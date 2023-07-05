using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class EstadoMap : IEntityTypeConfiguration<Estado>
    {
        public void Configure(EntityTypeBuilder<Estado> builder)
        {
            builder.Property(x => x.Nome)
                   .HasColumnType("VARCHAR")
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(x => x.Sigla)
                   .IsRequired()
                   .HasMaxLength(2);
        }
    }
}

