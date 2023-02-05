using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class Tryingtogettablesright : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_SizeId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "SizeId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Menu",
                newName: "Links");

            migrationBuilder.CreateTable(
                name: "Product_Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(name: "Product_Id", type: "int", nullable: false),
                    ProductId0 = table.Column<int>(name: "ProductId", type: "int", nullable: false),
                    SizeId = table.Column<int>(name: "Size_Id", type: "int", nullable: false),
                    SizeId0 = table.Column<int>(name: "SizeId", type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Sizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Sizes_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Product_Sizes_Products_ProductId",
                        column: x => x.ProductId0,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_Sizes_Sizes_SizeId",
                        column: x => x.SizeId0,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_Sizes_ColorId",
                table: "Product_Sizes",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Sizes_ProductId",
                table: "Product_Sizes",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_Sizes_SizeId",
                table: "Product_Sizes",
                column: "SizeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_Sizes");

            migrationBuilder.RenameColumn(
                name: "Links",
                table: "Menu",
                newName: "Link");

            migrationBuilder.AddColumn<int>(
                name: "SizeId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Sizes_SizeId",
                table: "Products",
                column: "SizeId",
                principalTable: "Sizes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
