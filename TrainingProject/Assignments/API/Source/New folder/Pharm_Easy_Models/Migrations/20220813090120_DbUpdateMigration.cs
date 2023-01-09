using Microsoft.EntityFrameworkCore.Migrations;

namespace Pharm_Easy_Models.Migrations
{
    public partial class DbUpdateMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_categories_Cat_Id1",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_sproducts_categories_Cat_Id1",
                table: "sproducts");

            migrationBuilder.DropTable(
                name: "catagories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_categories",
                table: "categories");

            migrationBuilder.RenameTable(
                name: "categories",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Cat_Id");

            migrationBuilder.CreateTable(
                name: "scatagories",
                columns: table => new
                {
                    Cat_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scatagories", x => x.Cat_Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_Cat_Id1",
                table: "products",
                column: "Cat_Id1",
                principalTable: "Categories",
                principalColumn: "Cat_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sproducts_scatagories_Cat_Id1",
                table: "sproducts",
                column: "Cat_Id1",
                principalTable: "scatagories",
                principalColumn: "Cat_Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_Cat_Id1",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_sproducts_scatagories_Cat_Id1",
                table: "sproducts");

            migrationBuilder.DropTable(
                name: "scatagories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_categories",
                table: "categories",
                column: "Cat_Id");

            migrationBuilder.CreateTable(
                name: "catagories",
                columns: table => new
                {
                    Cat_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_catagories", x => x.Cat_Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_products_categories_Cat_Id1",
                table: "products",
                column: "Cat_Id1",
                principalTable: "categories",
                principalColumn: "Cat_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_sproducts_categories_Cat_Id1",
                table: "sproducts",
                column: "Cat_Id1",
                principalTable: "categories",
                principalColumn: "Cat_Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
