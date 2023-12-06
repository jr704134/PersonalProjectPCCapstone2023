using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalProjectPCCapstone2023.Data.Migrations
{
    public partial class updatedMerch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 1,
                column: "ImagePath",
                value: "/Images/Tshirt.jpg");

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 2,
                column: "ImagePath",
                value: "/Images/Sweater.jpg");

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 3,
                column: "ImagePath",
                value: "/Images/Hoodie.jpg");

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 4,
                column: "ImagePath",
                value: "/Images/Hat.jpg");

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 5,
                column: "ImagePath",
                value: "/Images/Beanie.jpg");

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 6,
                column: "ImagePath",
                value: "/Images/Other.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 1,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 2,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 3,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 4,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 5,
                column: "ImagePath",
                value: null);

            migrationBuilder.UpdateData(
                table: "Merch",
                keyColumn: "MerchId",
                keyValue: 6,
                column: "ImagePath",
                value: null);
        }
    }
}
