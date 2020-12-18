using Microsoft.EntityFrameworkCore.Migrations;

namespace Catalog.Persistence.Database.Migrations
{
    public partial class Initialize : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "catalog");

            migrationBuilder.CreateTable(
                name: "products",
                schema: "catalog",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.ProductId);
                });

            migrationBuilder.CreateTable(
                name: "productinStocks",
                schema: "catalog",
                columns: table => new
                {
                    ProductInStockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productinStocks", x => x.ProductInStockId);
                    table.ForeignKey(
                        name: "FK_productinStocks_products_ProductId",
                        column: x => x.ProductId,
                        principalSchema: "catalog",
                        principalTable: "products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "description for product 1", "prodct 1", 871m },
                    { 73, "description for product 73", "prodct 73", 135m },
                    { 72, "description for product 72", "prodct 72", 271m },
                    { 71, "description for product 71", "prodct 71", 353m },
                    { 70, "description for product 70", "prodct 70", 254m },
                    { 69, "description for product 69", "prodct 69", 539m },
                    { 68, "description for product 68", "prodct 68", 248m },
                    { 67, "description for product 67", "prodct 67", 784m },
                    { 66, "description for product 66", "prodct 66", 602m },
                    { 65, "description for product 65", "prodct 65", 923m },
                    { 64, "description for product 64", "prodct 64", 633m },
                    { 63, "description for product 63", "prodct 63", 337m },
                    { 62, "description for product 62", "prodct 62", 828m },
                    { 61, "description for product 61", "prodct 61", 933m },
                    { 60, "description for product 60", "prodct 60", 637m },
                    { 59, "description for product 59", "prodct 59", 992m },
                    { 58, "description for product 58", "prodct 58", 606m },
                    { 57, "description for product 57", "prodct 57", 598m },
                    { 56, "description for product 56", "prodct 56", 935m },
                    { 55, "description for product 55", "prodct 55", 757m },
                    { 54, "description for product 54", "prodct 54", 603m },
                    { 53, "description for product 53", "prodct 53", 590m },
                    { 74, "description for product 74", "prodct 74", 552m },
                    { 52, "description for product 52", "prodct 52", 375m },
                    { 75, "description for product 75", "prodct 75", 171m },
                    { 77, "description for product 77", "prodct 77", 614m },
                    { 98, "description for product 98", "prodct 98", 786m },
                    { 97, "description for product 97", "prodct 97", 222m },
                    { 96, "description for product 96", "prodct 96", 965m },
                    { 95, "description for product 95", "prodct 95", 817m },
                    { 94, "description for product 94", "prodct 94", 377m },
                    { 93, "description for product 93", "prodct 93", 449m },
                    { 92, "description for product 92", "prodct 92", 309m },
                    { 91, "description for product 91", "prodct 91", 215m },
                    { 90, "description for product 90", "prodct 90", 493m },
                    { 89, "description for product 89", "prodct 89", 151m },
                    { 88, "description for product 88", "prodct 88", 271m },
                    { 87, "description for product 87", "prodct 87", 399m },
                    { 86, "description for product 86", "prodct 86", 392m },
                    { 85, "description for product 85", "prodct 85", 614m },
                    { 84, "description for product 84", "prodct 84", 133m },
                    { 83, "description for product 83", "prodct 83", 418m }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 82, "description for product 82", "prodct 82", 425m },
                    { 81, "description for product 81", "prodct 81", 288m },
                    { 80, "description for product 80", "prodct 80", 353m },
                    { 79, "description for product 79", "prodct 79", 229m },
                    { 78, "description for product 78", "prodct 78", 910m },
                    { 76, "description for product 76", "prodct 76", 480m },
                    { 51, "description for product 51", "prodct 51", 652m },
                    { 50, "description for product 50", "prodct 50", 411m },
                    { 49, "description for product 49", "prodct 49", 311m },
                    { 22, "description for product 22", "prodct 22", 935m },
                    { 21, "description for product 21", "prodct 21", 839m },
                    { 20, "description for product 20", "prodct 20", 865m },
                    { 19, "description for product 19", "prodct 19", 304m },
                    { 18, "description for product 18", "prodct 18", 949m },
                    { 17, "description for product 17", "prodct 17", 612m },
                    { 16, "description for product 16", "prodct 16", 170m },
                    { 15, "description for product 15", "prodct 15", 868m },
                    { 14, "description for product 14", "prodct 14", 868m },
                    { 13, "description for product 13", "prodct 13", 957m },
                    { 12, "description for product 12", "prodct 12", 559m },
                    { 11, "description for product 11", "prodct 11", 492m },
                    { 10, "description for product 10", "prodct 10", 591m },
                    { 9, "description for product 9", "prodct 9", 800m },
                    { 8, "description for product 8", "prodct 8", 682m },
                    { 7, "description for product 7", "prodct 7", 458m },
                    { 6, "description for product 6", "prodct 6", 153m },
                    { 5, "description for product 5", "prodct 5", 358m },
                    { 4, "description for product 4", "prodct 4", 612m },
                    { 3, "description for product 3", "prodct 3", 424m },
                    { 2, "description for product 2", "prodct 2", 821m },
                    { 23, "description for product 23", "prodct 23", 323m },
                    { 24, "description for product 24", "prodct 24", 818m },
                    { 25, "description for product 25", "prodct 25", 619m },
                    { 26, "description for product 26", "prodct 26", 721m },
                    { 48, "description for product 48", "prodct 48", 794m },
                    { 47, "description for product 47", "prodct 47", 533m },
                    { 46, "description for product 46", "prodct 46", 366m },
                    { 45, "description for product 45", "prodct 45", 688m },
                    { 44, "description for product 44", "prodct 44", 412m },
                    { 43, "description for product 43", "prodct 43", 420m },
                    { 42, "description for product 42", "prodct 42", 459m },
                    { 41, "description for product 41", "prodct 41", 794m }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "products",
                columns: new[] { "ProductId", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 40, "description for product 40", "prodct 40", 751m },
                    { 39, "description for product 39", "prodct 39", 914m },
                    { 99, "description for product 99", "prodct 99", 489m },
                    { 38, "description for product 38", "prodct 38", 441m },
                    { 36, "description for product 36", "prodct 36", 714m },
                    { 35, "description for product 35", "prodct 35", 429m },
                    { 34, "description for product 34", "prodct 34", 809m },
                    { 33, "description for product 33", "prodct 33", 774m },
                    { 32, "description for product 32", "prodct 32", 890m },
                    { 31, "description for product 31", "prodct 31", 668m },
                    { 30, "description for product 30", "prodct 30", 266m },
                    { 29, "description for product 29", "prodct 29", 445m },
                    { 28, "description for product 28", "prodct 28", 630m },
                    { 27, "description for product 27", "prodct 27", 219m },
                    { 37, "description for product 37", "prodct 37", 816m },
                    { 100, "description for product 100", "prodct 100", 186m }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "productinStocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 1, 1, 93 },
                    { 73, 73, 22 },
                    { 72, 72, 47 },
                    { 71, 71, 27 },
                    { 70, 70, 51 },
                    { 69, 69, 98 },
                    { 68, 68, 1 },
                    { 67, 67, 84 },
                    { 66, 66, 59 },
                    { 65, 65, 14 },
                    { 64, 64, 29 },
                    { 63, 63, 57 },
                    { 62, 62, 61 },
                    { 61, 61, 61 },
                    { 60, 60, 96 },
                    { 59, 59, 56 },
                    { 58, 58, 41 },
                    { 57, 57, 12 },
                    { 56, 56, 18 },
                    { 55, 55, 27 },
                    { 54, 54, 70 },
                    { 53, 53, 98 },
                    { 74, 74, 76 },
                    { 52, 52, 37 },
                    { 75, 75, 91 },
                    { 77, 77, 16 },
                    { 98, 98, 29 },
                    { 97, 97, 98 },
                    { 96, 96, 28 },
                    { 95, 95, 31 },
                    { 94, 94, 70 },
                    { 93, 93, 86 },
                    { 92, 92, 5 },
                    { 91, 91, 82 },
                    { 90, 90, 59 },
                    { 89, 89, 27 },
                    { 88, 88, 6 },
                    { 87, 87, 54 },
                    { 86, 86, 17 },
                    { 85, 85, 29 },
                    { 84, 84, 63 },
                    { 83, 83, 61 }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "productinStocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 82, 82, 60 },
                    { 81, 81, 61 },
                    { 80, 80, 65 },
                    { 79, 79, 36 },
                    { 78, 78, 71 },
                    { 76, 76, 48 },
                    { 51, 51, 41 },
                    { 50, 50, 38 },
                    { 49, 49, 76 },
                    { 22, 22, 75 },
                    { 21, 21, 3 },
                    { 20, 20, 81 },
                    { 19, 19, 69 },
                    { 18, 18, 89 },
                    { 17, 17, 90 },
                    { 16, 16, 74 },
                    { 15, 15, 46 },
                    { 14, 14, 76 },
                    { 13, 13, 55 },
                    { 12, 12, 61 },
                    { 11, 11, 12 },
                    { 10, 10, 69 },
                    { 9, 9, 0 },
                    { 8, 8, 58 },
                    { 7, 7, 99 },
                    { 6, 6, 74 },
                    { 5, 5, 59 },
                    { 4, 4, 38 },
                    { 3, 3, 14 },
                    { 2, 2, 87 },
                    { 23, 23, 75 },
                    { 24, 24, 72 },
                    { 25, 25, 81 },
                    { 26, 26, 63 },
                    { 48, 48, 52 },
                    { 47, 47, 2 },
                    { 46, 46, 16 },
                    { 45, 45, 36 },
                    { 44, 44, 4 },
                    { 43, 43, 58 },
                    { 42, 42, 55 },
                    { 41, 41, 89 }
                });

            migrationBuilder.InsertData(
                schema: "catalog",
                table: "productinStocks",
                columns: new[] { "ProductInStockId", "ProductId", "Stock" },
                values: new object[,]
                {
                    { 40, 40, 92 },
                    { 39, 39, 67 },
                    { 99, 99, 89 },
                    { 38, 38, 42 },
                    { 36, 36, 95 },
                    { 35, 35, 77 },
                    { 34, 34, 54 },
                    { 33, 33, 76 },
                    { 32, 32, 53 },
                    { 31, 31, 55 },
                    { 30, 30, 71 },
                    { 29, 29, 1 },
                    { 28, 28, 37 },
                    { 27, 27, 13 },
                    { 37, 37, 46 },
                    { 100, 100, 76 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_productinStocks_ProductId",
                schema: "catalog",
                table: "productinStocks",
                column: "ProductId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_ProductId",
                schema: "catalog",
                table: "products",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "productinStocks",
                schema: "catalog");

            migrationBuilder.DropTable(
                name: "products",
                schema: "catalog");
        }
    }
}
