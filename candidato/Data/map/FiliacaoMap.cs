using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class FiliacaoMap : IEntityTypeConfiguration<Filiacao>
    {
        public void Configure(EntityTypeBuilder<Filiacao> builder)
        {
           
            builder.Property(x => x.NomePai)
                   .HasColumnType("VARCHAR")
                   .HasMaxLength(200);


            builder.Property(x => x.NomeMae)
                   .HasColumnType("VARCHAR")
                   .IsRequired()
                   .HasMaxLength(200);
        }
    }
}


