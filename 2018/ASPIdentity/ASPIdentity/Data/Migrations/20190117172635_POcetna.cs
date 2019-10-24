using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ASPIdentity.Data.Migrations
{
    public partial class POcetna : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klub",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Ime = table.Column<string>(nullable: false),
                    Sport = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klub", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tekme",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Klub1Id = table.Column<int>(nullable: false),
                    Klub2Id = table.Column<int>(nullable: false),
                    Datum = table.Column<DateTime>(nullable: false),
                    Koeficijent = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tekme", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tekme_Klub_Klub1Id",
                        column: x => x.Klub1Id,
                        principalTable: "Klub",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                    table.ForeignKey(
                        name: "FK_Tekme_Klub_Klub2Id",
                        column: x => x.Klub2Id,
                        principalTable: "Klub",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Tekme_Klub1Id",
                table: "Tekme",
                column: "Klub1Id");

            migrationBuilder.CreateIndex(
                name: "IX_Tekme_Klub2Id",
                table: "Tekme",
                column: "Klub2Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tekme");

            migrationBuilder.DropTable(
                name: "Klub");
        }
    }
}
