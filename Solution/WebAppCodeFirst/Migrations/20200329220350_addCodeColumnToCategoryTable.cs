using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppCodeFirst.Migrations
{
    public partial class addCodeColumnToCategoryTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "category",
                unicode: false,
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "category");
        }
    }
}
