using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BRGAAP_teste_back.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigrattion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cliente",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cliente", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NotaFiscal",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Valor = table.Column<double>(type: "double precision", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uuid", nullable: false),
                    FornecedorId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotaFiscal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NotaFiscal_Cliente_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Cliente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotaFiscal_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_ClienteId",
                table: "NotaFiscal",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_NotaFiscal_FornecedorId",
                table: "NotaFiscal",
                column: "FornecedorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NotaFiscal");

            migrationBuilder.DropTable(
                name: "Cliente");

            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
