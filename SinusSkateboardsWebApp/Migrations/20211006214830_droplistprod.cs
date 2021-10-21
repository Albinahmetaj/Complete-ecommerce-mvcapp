using Microsoft.EntityFrameworkCore.Migrations;

namespace SinusSkateboardsWebApp.Migrations
{
    public partial class droplistprod : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Product_ProductModelProductId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ProductModelProductId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "ProductModelProductId",
                table: "Product");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductModelProductId",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductModelProductId",
                table: "Product",
                column: "ProductModelProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Product_ProductModelProductId",
                table: "Product",
                column: "ProductModelProductId",
                principalTable: "Product",
                principalColumn: "ProductId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
