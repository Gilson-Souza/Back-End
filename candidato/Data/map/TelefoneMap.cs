using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Numero).IsRequired().HasMaxLength(255);

            // Mapeamento do tipo de telefone (enum)
             builder.Property(x => x.Tipo)
                    .IsRequired()
                    .HasConversion<string>();
        }
    }
}

