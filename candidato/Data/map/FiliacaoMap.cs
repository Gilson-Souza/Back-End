using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class FiliacaoMap : IEntityTypeConfiguration<Filiacao>
    {
        public void Configure(EntityTypeBuilder<Filiacao> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.NomePai).HasMaxLength(255);
            builder.Property(x => x.NomeMae).IsRequired().HasMaxLength(255);
        }
    }
}


