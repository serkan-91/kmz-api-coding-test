using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kmz_api_coding_test.Persistence.Migrations
{
    public partial class Mig7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PerUnitQuantity",
                table: "Products",
                newName: "RemainStock");

            migrationBuilder.AddColumn<int>(
                name: "SaleUnitAmount",
                table: "InventoryProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleUnitAmount",
                table: "InventoryProducts");

            migrationBuilder.RenameColumn(
                name: "RemainStock",
                table: "Products",
                newName: "PerUnitQuantity");
        }
    }
}
