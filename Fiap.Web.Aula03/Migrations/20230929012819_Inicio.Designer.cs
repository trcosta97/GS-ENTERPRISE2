﻿// <auto-generated />
using System;
using Fiap.Web.Aula03.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Web.Aula03.Migrations
{
    [DbContext(typeof(StreamingContext))]
    [Migration("20230929012819_Inicio")]
    partial class Inicio
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

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

                    b.Property<string>("Sinopse")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.HasKey("FilmeId");

                    b.ToTable("Tb_Filme");
                });
#pragma warning restore 612, 618
        }
    }
}
