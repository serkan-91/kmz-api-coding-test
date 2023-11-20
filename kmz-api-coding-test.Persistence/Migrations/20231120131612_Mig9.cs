using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace kmz_api_coding_test.Persistence.Migrations
{
    public partial class Mig9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductAttributes_ProductAttributesId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductAttributesId",
                table: "Products",
                newName: "ProductAttributesProductAttributeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductAttributesId",
                table: "Products",
                newName: "IX_Products_ProductAttributesProductAttributeId");

            migrationBuilder.RenameColumn(
                name: "ProductAttributesId",
                table: "ProductAttributes",
                newName: "ProductAttributeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductAttributes_ProductAttributesProductAttributeId",
                table: "Products",
                column: "ProductAttributesProductAttributeId",
                principalTable: "ProductAttributes",
                principalColumn: "ProductAttributeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductAttributes_ProductAttributesProductAttributeId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "ProductAttributesProductAttributeId",
                table: "Products",
                newName: "ProductAttributesId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ProductAttributesProductAttributeId",
                table: "Products",
                newName: "IX_Products_ProductAttributesId");

            migrationBuilder.RenameColumn(
                name: "ProductAttributeId",
                table: "ProductAttributes",
                newName: "ProductAttributesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductAttributes_ProductAttributesId",
                table: "Products",
                column: "ProductAttributesId",
                principalTable: "ProductAttributes",
                principalColumn: "ProductAttributesId");
        }
    }
}
