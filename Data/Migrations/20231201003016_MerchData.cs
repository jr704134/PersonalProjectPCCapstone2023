using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalProjectPCCapstone2023.Data.Migrations
{
    public partial class MerchData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Order_Merch_MerchandiseMerchId",
                table: "Order");

            migrationBuilder.DropTable(
                name: "CategoryMerchandise");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Order_MerchandiseMerchId",
                table: "Orders",
                newName: "IX_Orders_MerchandiseMerchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "CategoryId");

            migrationBuilder.CreateTable(
                name: "MerchCategories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    MerchandiseMerchId = table.Column<int>(type: "int", nullable: false),
                    MerchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchCategories", x => new { x.CategoryId, x.MerchandiseMerchId });
                    table.ForeignKey(
                        name: "FK_MerchCategories_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MerchCategories_Merch_MerchId",
                        column: x => x.MerchId,
                        principalTable: "Merch",
                        principalColumn: "MerchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    PaymentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.PaymentId);
                });

            migrationBuilder.InsertData(
                table: "Merch",
                columns: new[] { "MerchId", "MerchName", "MerchPrice", "MerchSize", "UserId" },
                values: new object[] { 1, "Test", 25.0m, "Medium", null });

            migrationBuilder.CreateIndex(
                name: "IX_MerchCategories_MerchId",
                table: "MerchCategories",
                column: "MerchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Merch_MerchandiseMerchId",
                table: "Orders",
                column: "MerchandiseMerchId",
                principalTable: "Merch",
                principalColumn: "MerchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Merch_MerchandiseMerchId",
                table: "Orders");

            migrationBuilder.DropTable(
                name: "MerchCategories");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 1);

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_MerchandiseMerchId",
                table: "Order",
                newName: "IX_Order_MerchandiseMerchId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "CategoryId");

            migrationBuilder.CreateTable(
                name: "CategoryMerchandise",
                columns: table => new
                {
                    CategoriesCategoryId = table.Column<int>(type: "int", nullable: false),
                    MerchId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMerchandise", x => new { x.CategoriesCategoryId, x.MerchId });
                    table.ForeignKey(
                        name: "FK_CategoryMerchandise_Category_CategoriesCategoryId",
                        column: x => x.CategoriesCategoryId,
                        principalTable: "Category",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CategoryMerchandise_Merch_MerchId",
                        column: x => x.MerchId,
                        principalTable: "Merch",
                        principalColumn: "MerchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CategoryMerchandise_MerchId",
                table: "CategoryMerchandise",
                column: "MerchId");

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Merch_MerchandiseMerchId",
                table: "Order",
                column: "MerchandiseMerchId",
                principalTable: "Merch",
                principalColumn: "MerchId");
        }
    }
}
