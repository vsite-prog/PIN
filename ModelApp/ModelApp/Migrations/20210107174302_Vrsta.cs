using Microsoft.EntityFrameworkCore.Migrations;

namespace ModelApp.Migrations
{
    public partial class Vrsta : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Ljubimac",
                maxLength: 400,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Ljubimac",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "VrstaId",
                table: "Ljubimac",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Vrsta",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vrsta", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Ljubimac_VrstaId",
                table: "Ljubimac",
                column: "VrstaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Ljubimac_Vrsta_VrstaId",
                table: "Ljubimac",
                column: "VrstaId",
                principalTable: "Vrsta",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Ljubimac_Vrsta_VrstaId",
                table: "Ljubimac");

            migrationBuilder.DropTable(
                name: "Vrsta");

            migrationBuilder.DropIndex(
                name: "IX_Ljubimac_VrstaId",
                table: "Ljubimac");

            migrationBuilder.DropColumn(
                name: "VrstaId",
                table: "Ljubimac");

            migrationBuilder.AlterColumn<string>(
                name: "Opis",
                table: "Ljubimac",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 400,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Ljubimac",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 40);
        }
    }
}
