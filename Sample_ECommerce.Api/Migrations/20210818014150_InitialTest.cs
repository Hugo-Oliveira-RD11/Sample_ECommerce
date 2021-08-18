using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sample_ECommerce.Api.Migrations
{
    public partial class InitialTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    ClienteBusinessEntityId = table.Column<int>(type: "int", nullable: false)
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

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_CEP_ClienteBusinessEntityId",
                table: "Cliente_CEP",
                column: "ClienteBusinessEntityId");

            migrationBuilder.CreateIndex(
                name: "IX_Cliente_Phone_ClienteBusinessEntityId",
                table: "Cliente_Phone",
                column: "ClienteBusinessEntityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cliente_CEP");

            migrationBuilder.DropTable(
                name: "Cliente_Phone");

            migrationBuilder.DropTable(
                name: "Clientes");
        }
    }
}
