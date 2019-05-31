using Microsoft.EntityFrameworkCore.Migrations;

namespace ShopWeb.Migrations
{
    public partial class ModifyProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "Products",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
