using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PersonalProjectPCCapstone2023.Data.Migrations
{
    public partial class PaymentOrderChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CVC",
                table: "Payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "NameOnCard",
                table: "Payments",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CVC",
                table: "Payments");

            migrationBuilder.DropColumn(
                name: "NameOnCard",
                table: "Payments");
        }
    }
}
