using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kmz_api_coding_test.Persistence.Migrations
{
    public partial class Mig8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UnitPerQuantity",
                table: "InventoryProducts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UnitPerQuantity",
                table: "InventoryProducts");
        }
    }
}
