using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MovisisTecnologia.Data.Migrations
{
    public partial class um : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CIDADE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UF = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    NOME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CIDADE", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CLIENTE",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    APELIDO = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TELEFONE = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    DATA_NASCIMENTO = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ID_CLIENTE = table.Column<int>(type: "int", nullable: true),
                    NOME = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CLIENTE", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CLIENTE_CIDADE_ID_CLIENTE",
                        column: x => x.ID_CLIENTE,
                        principalTable: "CIDADE",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CLIENTE_ID_CLIENTE",
                table: "CLIENTE",
                column: "ID_CLIENTE");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CLIENTE");

            migrationBuilder.DropTable(
                name: "CIDADE");
        }
    }
}
