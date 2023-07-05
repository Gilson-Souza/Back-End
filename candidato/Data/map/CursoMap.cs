using candidato.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace candidato.Data.map
{
    public class CursoMap : IEntityTypeConfiguration<Curso>
    {
        public void Configure(EntityTypeBuilder<Curso> builder)
        {
          
            builder.Property(x => x.Nome)
                .HasColumnType("VARCHAR")
                .HasMaxLength(200)
                .IsRequired();

         

        }

    }
}
