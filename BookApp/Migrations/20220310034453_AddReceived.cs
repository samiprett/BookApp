using Microsoft.EntityFrameworkCore.Migrations;

namespace BookApp.Migrations
{
    public partial class AddReceived : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "PurchaseReceived",
                table: "Pay",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Pay",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PurchaseReceived",
                table: "Pay");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Pay");
        }
    }
}
