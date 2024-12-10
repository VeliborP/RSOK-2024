using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Dodata_tabela_Kategorija_Kreiran_FK_Proizvod_Kategorija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KategorijaId",
                table: "Proizvod",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Proizvod_KategorijaId",
                table: "Proizvod",
                column: "KategorijaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Proizvod_Kategorija",
                table: "Proizvod",
                column: "KategorijaId",
                principalTable: "Kategorija",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Proizvod_Kategorija",
                table: "Proizvod");

            migrationBuilder.DropIndex(
                name: "IX_Proizvod_KategorijaId",
                table: "Proizvod");

            migrationBuilder.DropColumn(
                name: "KategorijaId",
                table: "Proizvod");
        }
    }
}
