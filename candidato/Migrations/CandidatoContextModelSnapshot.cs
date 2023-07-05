﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using candidato.Data;

#nullable disable

namespace candidato.Migrations
{
    [DbContext(typeof(CandidatoContext))]
    partial class CandidatoContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("candidato.Models.Candidatoo", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("EnderecoId")
                        .HasColumnType("bigint");

                    b.Property<long>("FiliacaoId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.HasIndex("FiliacaoId")
                        .IsUnique();

                    b.ToTable("Candidatos");
                });

            modelBuilder.Entity("candidato.Models.Cidade", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long>("EstadoId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("EstadoId")
                        .IsUnique();

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("candidato.Models.Curso", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CandidatooId")
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CandidatooId");

                    b.ToTable("Cursos");
                });

            modelBuilder.Entity("candidato.Models.Endereco", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("varchar(10)");

                    b.Property<long>("CidadeId")
                        .HasColumnType("bigint");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CidadeId")
                        .IsUnique();

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("candidato.Models.Estado", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Sigla")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)");

                    b.HasKey("Id");

                    b.ToTable("Estados");
                });

            modelBuilder.Entity("candidato.Models.Filiacao", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<string>("NomeMae")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("NomePai")
                        .HasMaxLength(200)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Filiacoes");
                });

            modelBuilder.Entity("candidato.Models.Telefone", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    b.Property<long?>("CandidatooId")
                        .HasColumnType("bigint");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("Tipo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("CandidatooId");

                    b.ToTable("Telefones");
                });

            modelBuilder.Entity("candidato.Models.Candidatoo", b =>
                {
                    b.HasOne("candidato.Models.Endereco", "Endereco")
                        .WithOne()
                        .HasForeignKey("candidato.Models.Candidatoo", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("candidato.Models.Filiacao", "Filiacao")
                        .WithOne()
                        .HasForeignKey("candidato.Models.Candidatoo", "FiliacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");

                    b.Navigation("Filiacao");
                });

            modelBuilder.Entity("candidato.Models.Cidade", b =>
                {
                    b.HasOne("candidato.Models.Estado", "Estado")
                        .WithOne()
                        .HasForeignKey("candidato.Models.Cidade", "EstadoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Estado");
                });

            modelBuilder.Entity("candidato.Models.Curso", b =>
                {
                    b.HasOne("candidato.Models.Candidatoo", null)
                        .WithMany("Cursos")
                        .HasForeignKey("CandidatooId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("candidato.Models.Endereco", b =>
                {
                    b.HasOne("candidato.Models.Cidade", "Cidade")
                        .WithOne()
                        .HasForeignKey("candidato.Models.Endereco", "CidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cidade");
                });

            modelBuilder.Entity("candidato.Models.Telefone", b =>
                {
                    b.HasOne("candidato.Models.Candidatoo", null)
                        .WithMany("Telefones")
                        .HasForeignKey("CandidatooId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("candidato.Models.Candidatoo", b =>
                {
                    b.Navigation("Cursos");

                    b.Navigation("Telefones");
                });
#pragma warning restore 612, 618
        }
    }
}
