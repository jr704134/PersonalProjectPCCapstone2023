using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalProjectPCCapstone2023.Data.Migrations
{
    public partial class MerchSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Merch",
                columns: new[] { "MerchId", "MerchName", "MerchPrice", "MerchSize", "UserId" },
                values: new object[] { 1, "Test", 25.0m, null, null });

            migrationBuilder.InsertData(
                table: "Merch",
                columns: new[] { "MerchId", "MerchName", "MerchPrice", "MerchSize", "UserId" },
                values: new object[] { 2, "Test2", 35.0m, null, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 2);
        }
    }
}
