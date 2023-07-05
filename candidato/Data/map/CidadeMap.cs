using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class CidadeMap : IEntityTypeConfiguration<Cidade>
    {
        public void Configure(EntityTypeBuilder<Cidade> builder)
        {
                

                builder.Property(x => x.Nome)
                       .IsRequired()
                       .HasColumnType("VARCHAR")
                       .HasMaxLength(200);


            // Relacionamento com Estado
                builder.HasOne(c => c.Estado)
                       .WithOne()
                       .HasForeignKey<Cidade>(c => c.EstadoId)
                       .IsRequired()
                       .OnDelete(DeleteBehavior.Cascade);
                  
        }
    }
}

