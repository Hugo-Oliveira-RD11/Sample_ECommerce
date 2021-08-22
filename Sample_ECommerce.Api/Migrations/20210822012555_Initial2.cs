using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample_ECommerce.Api.Migrations
{
    public partial class Initial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Caracteristicas_Dimensao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Altura = table.Column<int>(type: "int", nullable: false),
                    Comprimento = table.Column<int>(type: "int", nullable: false),
                    Largura = table.Column<int>(type: "int", nullable: false),
                    peso = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caracteristicas_Dimensao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Caracteristicas_Preco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Desconto = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caracteristicas_Preco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    BusinessEntityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rowguid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FistName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CPF = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<int>(type: "int", nullable: false),
                    MyPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneID = table.Column<int>(type: "int", nullable: false),
                    CEPID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.BusinessEntityId);
                });

            migrationBuilder.CreateTable(
                name: "Consoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rowId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Embalagem = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Acessorios = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Memoria = table.Column<int>(type: "int", nullable: false),
                    MTipo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Processador = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PVelocidade = table.Column<int>(type: "int", nullable: false),
                    PNucleos = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: false),
                    Cnpj = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoMarca = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(450)", maxLength: 450, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Senha = table.Column<string>(type: "nvarchar(80)", maxLength: 80, nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(1900)", maxLength: 1900, nullable: true),
                    FotoId = table.Column<int>(type: "int", nullable: false),
                    Tag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estoque = table.Column<int>(type: "int", nullable: false),
                    PrecoId = table.Column<int>(type: "int", nullable: false),
                    DimensaoId = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Produtos_Caracteristicas_Dimensao_DimensaoId",
                        column: x => x.DimensaoId,
                        principalTable: "Caracteristicas_Dimensao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Produtos_Caracteristicas_Preco_PrecoId",
                        column: x => x.PrecoId,
                        principalTable: "Caracteristicas_Preco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente_CEP",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<int>(type: "int", nullable: false),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Numero_residencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClienteBusinessEntityId = table.Column<int>(type: "int", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente_CEP", x => x.ClienteID);
                    table.ForeignKey(
                        name: "FK_Cliente_CEP_Clientes_ClienteBusinessEntityId",
                        column: x => x.ClienteBusinessEntityId,
                        principalTable: "Clientes",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cliente_Phone",
                columns: table => new
                {
                    ClienteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PhoneNumber = table.Column<int>(type: "int", nullable: false),
                    TypePhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClienteBusinessEntityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente_Phone", x => x.ClienteID);
                    table.ForeignKey(
                        name: "FK_Cliente_Phone_Clientes_ClienteBusinessEntityId",
                        column: x => x.ClienteBusinessEntityId,
                        principalTable: "Clientes",
                        principalColumn: "BusinessEntityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor_Ceps",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereco = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumeroResidencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Complemento = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FornecedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor_Ceps", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Ceps_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor_Phones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypePhoneNumber = table.Column<long>(type: "bigint", nullable: false),
                    FornecedorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor_Phones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fornecedor_Phones_Fornecedores_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Caracteristicas_Imagem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LocalFoto1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProdutoID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caracteristicas_Imagem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caracteristicas_Imagem_Produtos_ProdutoID",
                        column: x => x.ProdutoID,
                        principalTable: "Produtos",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Caracteristicas_Imagem_ProdutoID",
                table: "Caracteristicas_Imagem",
                column: "ProdutoID");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CEP_ClienteBusinessEntityId",
                table: "Cliente_CEP",
                column: "ClienteBusinessEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Phone_ClienteBusinessEntityId",
                table: "Cliente_Phone",
                column: "ClienteBusinessEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Ceps_FornecedorId",
                table: "Fornecedor_Ceps",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Fornecedor_Phones_FornecedorId",
                table: "Fornecedor_Phones",
                column: "FornecedorId");

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_DimensaoId",
                table: "Produtos",
                column: "DimensaoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_PrecoId",
                table: "Produtos",
                column: "PrecoId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Caracteristicas_Imagem");

            migrationBuilder.DropTable(
                name: "Cliente_CEP");

            migrationBuilder.DropTable(
                name: "Cliente_Phone");

            migrationBuilder.DropTable(
                name: "Consoles");

            migrationBuilder.DropTable(
                name: "Fornecedor_Ceps");

            migrationBuilder.DropTable(
                name: "Fornecedor_Phones");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Fornecedores");

            migrationBuilder.DropTable(
                name: "Caracteristicas_Dimensao");

            migrationBuilder.DropTable(
                name: "Caracteristicas_Preco");
        }
    }
}
