using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class CandidatoMap : IEntityTypeConfiguration<Candidatoo>
    {
        public void Configure(EntityTypeBuilder<Candidatoo> builder)
        {
                    
                    builder.HasKey(x => x.Id);
                        
                    builder.Property(x => x.Nome)
                           .IsRequired()
                           .HasMaxLength(255);


                    builder.Property(x => x.FiliacaoId)
                           .IsRequired();

                    builder.Property(x => x.EnderecoId)
                           .IsRequired();   
            

                    builder.HasOne(x => x.Filiacao)
                           .WithOne()
                           .OnDelete(DeleteBehavior.Cascade);
                
                    builder.HasOne(x => x.Endereco)
                           .WithOne() 
                           .OnDelete(DeleteBehavior.Cascade);


                    builder.HasMany(x => x.Telefones)
                           .WithOne()                          
                           .OnDelete(DeleteBehavior.Cascade);

                    builder.HasMany(x => x.Cursos)      
                           .WithOne()
                           .OnDelete(DeleteBehavior.Cascade);


        }
    }
}









