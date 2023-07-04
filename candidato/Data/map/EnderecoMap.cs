using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(255);
            builder.Property(x => x.Cep).IsRequired().HasMaxLength(10);
            builder.Property(x => x.Numero).IsRequired();

            builder.HasOne(x => x.Cidade)
                   .WithOne()
                   .OnDelete(DeleteBehavior.Cascade)
                   .IsRequired();
        }
    }
}


