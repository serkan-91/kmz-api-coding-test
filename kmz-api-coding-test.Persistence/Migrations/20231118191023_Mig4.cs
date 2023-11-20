using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kmz_api_coding_test.Persistence.Migrations
{
    public partial class Mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryProduct_Inventories_InventoriesInventoryId",
                table: "InventoryProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryProduct",
                table: "InventoryProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "InventoriesInventoryId",
                table: "InventoryProduct");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "Inventories");

            migrationBuilder.AddColumn<string>(
                name: "InventoriesSKU",
                table: "InventoryProduct",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "Inventories",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryProduct",
                table: "InventoryProduct",
                columns: new[] { "InventoriesSKU", "ProductsProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "SKU");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryProduct_Inventories_InventoriesSKU",
                table: "InventoryProduct",
                column: "InventoriesSKU",
                principalTable: "Inventories",
                principalColumn: "SKU",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryProduct_Inventories_InventoriesSKU",
                table: "InventoryProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InventoryProduct",
                table: "InventoryProduct");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories");

            migrationBuilder.DropColumn(
                name: "InventoriesSKU",
                table: "InventoryProduct");

            migrationBuilder.AddColumn<int>(
                name: "InventoriesInventoryId",
                table: "InventoryProduct",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "SKU",
                table: "Inventories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "Inventories",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InventoryProduct",
                table: "InventoryProduct",
                columns: new[] { "InventoriesInventoryId", "ProductsProductId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Inventories",
                table: "Inventories",
                column: "InventoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryProduct_Inventories_InventoriesInventoryId",
                table: "InventoryProduct",
                column: "InventoriesInventoryId",
                principalTable: "Inventories",
                principalColumn: "InventoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
