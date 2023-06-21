using candidato.Data.map;
using candidato.Models;
using Microsoft.EntityFrameworkCore;
namespace candidato.Data;

public class CandidatoContext : DbContext
{
    public CandidatoContext(DbContextOptions<CandidatoContext> options) : base(options) 
    { 

    }
    public DbSet<Candidatoo> Candidatos { get; set; }
    public DbSet<Curso> Cursos { get; set; }
    public DbSet<Cidade> Cidades { get; set; }
    public DbSet<Endereco> Enderecos { get; set; }
    public DbSet<Estado> Estados { get; set; }
    public DbSet<Filiacao> Filiacoes { get; set; }
    public DbSet<Telefone> Telefones { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CursoMap());
        modelBuilder.ApplyConfiguration(new CandidatoMap());
        modelBuilder.ApplyConfiguration(new CidadeMap());
        modelBuilder.ApplyConfiguration(new EnderecoMap());
        modelBuilder.ApplyConfiguration(new EstadoMap());
        modelBuilder.ApplyConfiguration(new FiliacaoMap());
        modelBuilder.ApplyConfiguration(new TelefoneMap());
        base.OnModelCreating(modelBuilder);
    }





}

