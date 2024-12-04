using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class col_Opis_tbl_Kategorija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Opis",
                table: "Kategorija",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Opis",
                table: "Kategorija");
        }
    }
}
