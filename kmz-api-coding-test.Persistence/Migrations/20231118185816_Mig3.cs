using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kmz_api_coding_test.Persistence.Migrations
{
    public partial class Mig3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Quantity",
                table: "Inventories",
                newName: "UnitQuantity");

            migrationBuilder.AddColumn<int>(
                name: "StockQuantity",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockQuantity",
                table: "Inventories");

            migrationBuilder.RenameColumn(
                name: "UnitQuantity",
                table: "Inventories",
                newName: "Quantity");
        }
    }
}
