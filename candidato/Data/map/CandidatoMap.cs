using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class CandidatoMap : IEntityTypeConfiguration<Candidatoo>
    {
        public void Configure(EntityTypeBuilder<Candidatoo> builder)
        {
                    
                   
                        
                    builder.Property(x => x.Nome)
                           .IsRequired()
                           .HasColumnType("VARCHAR")
                           .HasMaxLength(200);


                    builder.HasOne(x => x.Filiacao)
                           .WithOne()
                           .OnDelete(DeleteBehavior.Cascade)
                           .HasForeignKey<Candidatoo>(c => c.FiliacaoId);

                builder.HasOne(x => x.Endereco)
                           .WithOne()
                           .OnDelete(DeleteBehavior.Cascade)
                           .HasForeignKey<Candidatoo>(c => c.EnderecoId);


                    builder.HasMany(x => x.Telefones)
                           .WithOne()                          
                           .OnDelete(DeleteBehavior.Cascade);

                    builder.HasMany(x => x.Cursos)      
                           .WithOne()
                           .OnDelete(DeleteBehavior.Cascade);


        }
    }
}









