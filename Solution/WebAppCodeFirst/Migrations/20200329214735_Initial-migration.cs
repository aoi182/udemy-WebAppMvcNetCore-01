using Microsoft.EntityFrameworkCore.Migrations;

namespace WebAppCodeFirst.Migrations
{
    public partial class Initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "category",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(maxLength: 50, nullable: false),
                    description = table.Column<string>(maxLength: 520, nullable: true),
                    status = table.Column<bool>(nullable: true, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_category", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(nullable: false),
                    code = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    name = table.Column<string>(maxLength: 120, nullable: false),
                    description = table.Column<string>(unicode: false, maxLength: 520, nullable: true),
                    selling_price = table.Column<decimal>(type: "decimal(11, 2)", nullable: false),
                    stock = table.Column<int>(nullable: false),
                    status = table.Column<bool>(nullable: false, defaultValue: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.id);
                    table.ForeignKey(
                        name: "FK_product_to_category",
                        column: x => x.CategoryId,
                        principalTable: "category",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_product_CategoryId",
                table: "product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "category");
        }
    }
}
