﻿// <auto-generated />
using System;
using LivrariaMHS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LivrariaMHS.Migrations
{
    [DbContext(typeof(LivrariaMHSContext))]
    partial class LivrariaMHSContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Autor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("ID");

                    b.ToTable("Autores");
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Bairro", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("ID");

                    b.ToTable("Bairros");
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Categoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Cidade", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("ID");

                    b.ToTable("Cidades");
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BairroID");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(14);

                    b.Property<int>("CidadeID");

                    b.Property<DateTime>("DataNascimento");

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasMaxLength(8);

                    b.Property<int>("RuaID");

                    b.Property<int>("Sexo");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasMaxLength(14);

                    b.HasKey("ID");

                    b.HasIndex("BairroID");

                    b.HasIndex("CidadeID");

                    b.HasIndex("RuaID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Livro", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Ano");

                    b.Property<int>("AutorID");

                    b.Property<int?>("CategoriaID");

                    b.Property<int>("Edicao");

                    b.Property<int>("Paginas");

                    b.Property<double>("Preco");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("ID");

                    b.HasIndex("AutorID");

                    b.HasIndex("CategoriaID");

                    b.ToTable("Livros");
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.LivroCategoria", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoriaID");

                    b.Property<int>("LivroID");

                    b.HasKey("ID");

                    b.HasIndex("CategoriaID");

                    b.HasIndex("LivroID");

                    b.ToTable("LivroCategoria");
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Rua", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(70);

                    b.HasKey("ID");

                    b.ToTable("Ruas");
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Venda", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteID");

                    b.Property<DateTime>("Data");

                    b.Property<int>("LivroID");

                    b.Property<int>("Quantidade");

                    b.Property<double>("ValorUnitario");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.HasIndex("LivroID");

                    b.ToTable("Vendas");
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Cliente", b =>
                {
                    b.HasOne("LivrariaMHS.Models.Attributes.Bairro", "Bairro")
                        .WithMany()
                        .HasForeignKey("BairroID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LivrariaMHS.Models.Attributes.Cidade", "Cidade")
                        .WithMany()
                        .HasForeignKey("CidadeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LivrariaMHS.Models.Attributes.Rua", "Rua")
                        .WithMany()
                        .HasForeignKey("RuaID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Livro", b =>
                {
                    b.HasOne("LivrariaMHS.Models.Attributes.Autor", "Autor")
                        .WithMany("Livros")
                        .HasForeignKey("AutorID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LivrariaMHS.Models.Attributes.Categoria")
                        .WithMany("Livros")
                        .HasForeignKey("CategoriaID");
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.LivroCategoria", b =>
                {
                    b.HasOne("LivrariaMHS.Models.Attributes.Categoria", "Categoria")
                        .WithMany("LivrosCategorias")
                        .HasForeignKey("CategoriaID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LivrariaMHS.Models.Attributes.Livro", "Livro")
                        .WithMany("LivrosCategorias")
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("LivrariaMHS.Models.Attributes.Venda", b =>
                {
                    b.HasOne("LivrariaMHS.Models.Attributes.Cliente", "Cliente")
                        .WithMany("Vendas")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("LivrariaMHS.Models.Attributes.Livro", "Livro")
                        .WithMany()
                        .HasForeignKey("LivroID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
