using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesBoard.Data.Migrations
{
    public partial class ItemNameandPrice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ItemName",
                table: "Carts",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ItemPrice",
                table: "Carts",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ItemName",
                table: "Carts");

            migrationBuilder.DropColumn(
                name: "ItemPrice",
                table: "Carts");
        }
    }
}
