using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplicationMVC.Migrations
{
    /// <inheritdoc />
    public partial class StokSütunuEkleme : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Stok",
                table: "Ürünler",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Stok",
                table: "Ürünler");
        }
    }
}
