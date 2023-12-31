﻿// <auto-generated />
using System;
using Fiap.Web.Aula03.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Web.Aula03.Migrations
{
    [DbContext(typeof(StreamingContext))]
    partial class StreamingContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Fiap.Web.Aula03.Models.Ator", b =>
                {
                    b.Property<int>("AtorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtorId"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("Nacionalidade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<bool>("Premiado")
                        .HasColumnType("bit");

                    b.HasKey("AtorId");

                    b.ToTable("Tbl_Ator");
                });

            modelBuilder.Entity("Fiap.Web.Aula03.Models.Filme", b =>
                {
                    b.Property<int>("FilmeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FilmeId"));

                    b.Property<decimal>("Bilheteria")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataLancamento")
                        .HasColumnType("datetime2")
                        .HasColumnName("Dt_Lancamento");

                    b.Property<bool>("Disponivel")
                        .HasColumnType("bit");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoraId")
                        .HasColumnType("int");

                    b.Property<string>("Sinopse")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("FilmeId");

                    b.HasIndex("ProdutoraId");

                    b.ToTable("Tb_Filme");
                });

            modelBuilder.Entity("Fiap.Web.Aula03.Models.FilmeAtor", b =>
                {
                    b.Property<int>("AtorId")
                        .HasColumnType("int");

                    b.Property<int>("FilmeId")
                        .HasColumnType("int");

                    b.HasKey("AtorId", "FilmeId");

                    b.HasIndex("FilmeId");

                    b.ToTable("Tbl_Filme_Ator");
                });

            modelBuilder.Entity("Fiap.Web.Aula03.Models.Presidente", b =>
                {
                    b.Property<int>("PresidenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PresidenteId"));

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PresidenteId");

                    b.ToTable("Tbl_Presidente");
                });

            modelBuilder.Entity("Fiap.Web.Aula03.Models.Produtora", b =>
                {
                    b.Property<int>("ProdutoraId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("Id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdutoraId"));

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Premios")
                        .HasColumnType("int");

                    b.Property<int>("PresidenteId")
                        .HasColumnType("int");

                    b.HasKey("ProdutoraId");

                    b.HasIndex("PresidenteId");

                    b.ToTable("Tbl_Produtora");
                });

            modelBuilder.Entity("Fiap.Web.Aula03.Models.Filme", b =>
                {
                    b.HasOne("Fiap.Web.Aula03.Models.Produtora", "Produtora")
                        .WithMany("Filmes")
                        .HasForeignKey("ProdutoraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produtora");
                });

            modelBuilder.Entity("Fiap.Web.Aula03.Models.FilmeAtor", b =>
                {
                    b.HasOne("Fiap.Web.Aula03.Models.Ator", "Ator")
                        .WithMany("FilmesAtores")
                        .HasForeignKey("AtorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Fiap.Web.Aula03.Models.Filme", "Filme")
                        .WithMany("FilmesAtores")
                        .HasForeignKey("FilmeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ator");

                    b.Navigation("Filme");
                });

            modelBuilder.Entity("Fiap.Web.Aula03.Models.Produtora", b =>
                {
                    b.HasOne("Fiap.Web.Aula03.Models.Presidente", "Presidente")
                        .WithMany()
                        .HasForeignKey("PresidenteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Presidente");
                });

            modelBuilder.Entity("Fiap.Web.Aula03.Models.Ator", b =>
                {
                    b.Navigation("FilmesAtores");
                });

            modelBuilder.Entity("Fiap.Web.Aula03.Models.Filme", b =>
                {
                    b.Navigation("FilmesAtores");
                });

            modelBuilder.Entity("Fiap.Web.Aula03.Models.Produtora", b =>
                {
                    b.Navigation("Filmes");
                });
#pragma warning restore 612, 618
        }
    }
}
