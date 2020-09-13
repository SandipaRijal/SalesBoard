using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesBoard.Data.Migrations
{
    public partial class changeInttostringitemname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Item",
                table: "Sales",
                nullable: true,
                oldClrType: typeof(int));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Item",
                table: "Sales",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
