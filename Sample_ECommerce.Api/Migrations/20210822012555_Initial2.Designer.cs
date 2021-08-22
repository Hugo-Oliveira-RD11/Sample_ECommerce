﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Sample_ECommerce.Api.Models;

namespace Sample_ECommerce.Api.Migrations
{
    [DbContext(typeof(AppDataContext))]
    [Migration("20210822012555_Initial2")]
    partial class Initial2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Cliente_CEP", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CEP")
                        .HasColumnType("int");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ClienteBusinessEntityId")
                        .HasColumnType("int");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Numero_residencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ClienteID");

                    b.HasIndex("ClienteBusinessEntityId");

                    b.ToTable("Cliente_CEP");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Cliente_Cliente", b =>
                {
                    b.Property<int>("BusinessEntityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CEPID")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FistName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gender")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MyPhoto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Password")
                        .HasColumnType("int");

                    b.Property<int>("PhoneID")
                        .HasColumnType("int");

                    b.Property<Guid>("Rowguid")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BusinessEntityId");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Cliente_Phone", b =>
                {
                    b.Property<int>("ClienteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClienteBusinessEntityId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PhoneNumber")
                        .HasColumnType("int");

                    b.Property<long>("TypePhoneNumber")
                        .HasColumnType("bigint");

                    b.HasKey("ClienteID");

                    b.HasIndex("ClienteBusinessEntityId");

                    b.ToTable("Cliente_Phone");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Fornecedor.Fornecedor_Cep", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NumeroResidencia")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Fornecedor_Ceps");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Fornecedor.Fornecedor_Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(450)
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LogoMarca")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<string>("Senha")
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Fornecedor.Fornecedor_Phone", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("TypePhoneNumber")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Fornecedor_Phones");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Produto.Caracteristicas.Caracteristicas_Dimensao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Altura")
                        .HasColumnType("int");

                    b.Property<int>("Comprimento")
                        .HasColumnType("int");

                    b.Property<int>("Largura")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("peso")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Caracteristicas_Dimensao");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Produto.Caracteristicas.Caracteristicas_Imagem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LocalFoto1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ProdutoID")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutoID");

                    b.ToTable("Caracteristicas_Imagem");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Produto.Caracteristicas.Caracteristicas_Preco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("Desconto")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Caracteristicas_Preco");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Produto.Produto_Console", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Acessorios")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Embalagem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MTipo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Memoria")
                        .HasColumnType("int");

                    b.Property<int>("PNucleos")
                        .HasColumnType("int");

                    b.Property<int>("PVelocidade")
                        .HasColumnType("int");

                    b.Property<string>("Processador")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("rowId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Consoles");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Produto.Produto_Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao")
                        .HasMaxLength(1900)
                        .HasColumnType("nvarchar(1900)");

                    b.Property<int>("DimensaoId")
                        .HasColumnType("int");

                    b.Property<int>("Estoque")
                        .HasColumnType("int");

                    b.Property<int>("FotoId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ModifiedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<int>("PrecoId")
                        .HasColumnType("int");

                    b.Property<string>("Tag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("DimensaoId")
                        .IsUnique();

                    b.HasIndex("PrecoId")
                        .IsUnique();

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Cliente_CEP", b =>
                {
                    b.HasOne("Sample_ECommerce.Api.Models.Cliente_Cliente", "Cliente")
                        .WithMany("CEP")
                        .HasForeignKey("ClienteBusinessEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Cliente_Phone", b =>
                {
                    b.HasOne("Sample_ECommerce.Api.Models.Cliente_Cliente", "Cliente")
                        .WithMany("Phone")
                        .HasForeignKey("ClienteBusinessEntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Fornecedor.Fornecedor_Cep", b =>
                {
                    b.HasOne("Sample_ECommerce.Api.Models.Fornecedor.Fornecedor_Fornecedor", "Fornecedor")
                        .WithMany("Cep")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Fornecedor.Fornecedor_Phone", b =>
                {
                    b.HasOne("Sample_ECommerce.Api.Models.Fornecedor.Fornecedor_Fornecedor", "Fornecedor")
                        .WithMany("Phone")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Produto.Caracteristicas.Caracteristicas_Imagem", b =>
                {
                    b.HasOne("Sample_ECommerce.Api.Models.Produto.Produto_Produto", "Produto")
                        .WithMany("Foto")
                        .HasForeignKey("ProdutoID");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Produto.Produto_Produto", b =>
                {
                    b.HasOne("Sample_ECommerce.Api.Models.Produto.Caracteristicas.Caracteristicas_Dimensao", "Dimensao")
                        .WithOne("Produto")
                        .HasForeignKey("Sample_ECommerce.Api.Models.Produto.Produto_Produto", "DimensaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Sample_ECommerce.Api.Models.Produto.Caracteristicas.Caracteristicas_Preco", "Preco")
                        .WithOne("Produto")
                        .HasForeignKey("Sample_ECommerce.Api.Models.Produto.Produto_Produto", "PrecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dimensao");

                    b.Navigation("Preco");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Cliente_Cliente", b =>
                {
                    b.Navigation("CEP");

                    b.Navigation("Phone");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Fornecedor.Fornecedor_Fornecedor", b =>
                {
                    b.Navigation("Cep");

                    b.Navigation("Phone");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Produto.Caracteristicas.Caracteristicas_Dimensao", b =>
                {
                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Produto.Caracteristicas.Caracteristicas_Preco", b =>
                {
                    b.Navigation("Produto");
                });

            modelBuilder.Entity("Sample_ECommerce.Api.Models.Produto.Produto_Produto", b =>
                {
                    b.Navigation("Foto");
                });
#pragma warning restore 612, 618
        }
    }
}