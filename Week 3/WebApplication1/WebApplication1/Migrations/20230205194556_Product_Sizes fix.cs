using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class ProductSizesfix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Sizes_Colors_ColorId",
                table: "Product_Sizes");

            migrationBuilder.DropIndex(
                name: "IX_Product_Sizes_ColorId",
                table: "Product_Sizes");

            migrationBuilder.DropColumn(
                name: "ColorId",
                table: "Product_Sizes");

            migrationBuilder.DropColumn(
                name: "Product_Id",
                table: "Product_Sizes");

            migrationBuilder.DropColumn(
                name: "Size_Id",
                table: "Product_Sizes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ColorId",
                table: "Product_Sizes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Product_Id",
                table: "Product_Sizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Size_Id",
                table: "Product_Sizes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Product_Sizes_ColorId",
                table: "Product_Sizes",
                column: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Sizes_Colors_ColorId",
                table: "Product_Sizes",
                column: "ColorId",
                principalTable: "Colors",
                principalColumn: "Id");
        }
    }
}
