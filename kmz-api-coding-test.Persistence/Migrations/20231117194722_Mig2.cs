using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kmz_api_coding_test.Persistence.Migrations
{
    public partial class Mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SalesUnitID",
                table: "ProductPrices",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ProductPrices_SalesUnitID",
                table: "ProductPrices",
                column: "SalesUnitID");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductPrices_SalesUnits_SalesUnitID",
                table: "ProductPrices",
                column: "SalesUnitID",
                principalTable: "SalesUnits",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductPrices_SalesUnits_SalesUnitID",
                table: "ProductPrices");

            migrationBuilder.DropIndex(
                name: "IX_ProductPrices_SalesUnitID",
                table: "ProductPrices");

            migrationBuilder.DropColumn(
                name: "SalesUnitID",
                table: "ProductPrices");
        }
    }
}
