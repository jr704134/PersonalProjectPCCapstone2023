using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalProjectPCCapstone2023.Data.Migrations
{
    public partial class newseeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 1,
                column: "MerchName",
                value: "T-Shirt");

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 2,
                column: "MerchName",
                value: "Sweater");

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 3,
                column: "MerchName",
                value: "Hoodie");

            migrationBuilder.InsertData(
                table: "Merch",
                columns: new[] { "MerchId", "MerchName", "MerchPrice", "MerchSize", "UserId" },
                values: new object[,]
                {
                    { 4, "Hat", 20.0m, null, null },
                    { 5, "Beanie", 21.0m, null, null },
                    { 6, "Backpack", 30.0m, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 1,
                column: "MerchName",
                value: "Test");

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 2,
                column: "MerchName",
                value: "Test2");

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 3,
                column: "MerchName",
                value: "Test3");
        }
    }
}
