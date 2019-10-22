﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Receita.Api.Infrastructure;

namespace Receita.Api.Infrastructure.ReceitaMigration
{
    [DbContext(typeof(ReceitaContext))]
    partial class ReceitaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Receita.Api.Model.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.ToTable("Categoria");
                });

            modelBuilder.Entity("Receita.Api.Model.Receita", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriaId");

                    b.Property<string>("Descricao");

                    b.Property<int>("IdCategoria");

                    b.Property<string>("Ingredientes");

                    b.Property<string>("ModoPreparo");

                    b.Property<string>("Titulo");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Receita");
                });

            modelBuilder.Entity("Receita.Api.Model.Receita", b =>
                {
                    b.HasOne("Receita.Api.Model.Categoria", "Categoria")
                        .WithMany()
                        .HasForeignKey("CategoriaId");
                });
#pragma warning restore 612, 618
        }
    }
}