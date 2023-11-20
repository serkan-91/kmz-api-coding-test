using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kmz_api_coding_test.Persistence.Migrations
{
    public partial class Mig6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductsId",
                table: "InventoryProducts");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductsId",
                table: "InventoryProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
