using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
       
            builder.Property(x => x.Numero)
                   .HasColumnType("VARCHAR")
                   .IsRequired()
                   .HasMaxLength(15);

            // Mapeamento do tipo de telefone (enum)
             builder.Property(x => x.Tipo)
                    .IsRequired()
                    .HasConversion<string>();

          
        }
    }
}

