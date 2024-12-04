using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebShop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class dodata_tbl_Proizvod : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Proizvod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Sifra = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    KratakOpis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Opis = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proizvod", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Proizvod");
        }
    }
}
