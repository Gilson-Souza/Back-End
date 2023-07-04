using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
                 builder.HasKey(x => x.Id);


                builder.Property(x => x.Nome)
                       .IsRequired()
                       .HasMaxLength(255);


            // Relacionamento com Estado
                builder.HasOne(c => c.Estado)
                       .WithOne()
                       .IsRequired()
                       .OnDelete(DeleteBehavior.Cascade);
                  
        }
    }
}

