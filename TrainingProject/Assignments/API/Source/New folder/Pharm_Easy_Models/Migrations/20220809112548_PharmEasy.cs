using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Pharm_Easy_Models.Migrations
{
    public partial class PharmEasy : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cArticles",
                columns: table => new
                {
                    A_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    C_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    A_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    A_Discription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cArticles", x => x.A_Id);
                });

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

            migrationBuilder.CreateTable(
                name: "categories",
                columns: table => new
                {
                    Cat_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cat_Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categories", x => x.Cat_Id);
                });

            migrationBuilder.CreateTable(
                name: "displayDetails",
                columns: table => new
                {
                    Full_Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Display_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pincode = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_displayDetails", x => x.Full_Name);
                });

            migrationBuilder.CreateTable(
                name: "hArticles",
                columns: table => new
                {
                    H_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    H_Discription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hArticles", x => x.H_Id);
                });

            migrationBuilder.CreateTable(
                name: "logins",
                columns: table => new
                {
                    Mobile_Number = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Create_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Conform_Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GST_Number = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_logins", x => x.Mobile_Number);
                });

            migrationBuilder.CreateTable(
                name: "offers",
                columns: table => new
                {
                    Off_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Off_Discription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Off_Code = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_offers", x => x.Off_Id);
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Pr_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pr_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pr_Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pr_Price = table.Column<int>(type: "int", nullable: false),
                    Cat_Id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Pr_Id);
                    table.ForeignKey(
                        name: "FK_products_categories_Cat_Id1",
                        column: x => x.Cat_Id1,
                        principalTable: "categories",
                        principalColumn: "Cat_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "sproducts",
                columns: table => new
                {
                    Pr_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pr_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pr_Discription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pr_Price = table.Column<int>(type: "int", nullable: false),
                    Cat_Id1 = table.Column<int>(type: "int", nullable: true),
                    Brand_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sproducts", x => x.Pr_Id);
                    table.ForeignKey(
                        name: "FK_sproducts_categories_Cat_Id1",
                        column: x => x.Cat_Id1,
                        principalTable: "categories",
                        principalColumn: "Cat_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "orders",
                columns: table => new
                {
                    o_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    o_Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pr_Id1 = table.Column<int>(type: "int", nullable: true),
                    o_quantity = table.Column<int>(type: "int", nullable: false),
                    Off_Id1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_orders", x => x.o_Id);
                    table.ForeignKey(
                        name: "FK_orders_offers_Off_Id1",
                        column: x => x.Off_Id1,
                        principalTable: "offers",
                        principalColumn: "Off_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_orders_products_Pr_Id1",
                        column: x => x.Pr_Id1,
                        principalTable: "products",
                        principalColumn: "Pr_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "carts",
                columns: table => new
                {
                    C_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Off_Id1 = table.Column<int>(type: "int", nullable: true),
                    o_quantityo_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_carts", x => x.C_Id);
                    table.ForeignKey(
                        name: "FK_carts_offers_Off_Id1",
                        column: x => x.Off_Id1,
                        principalTable: "offers",
                        principalColumn: "Off_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_carts_orders_o_quantityo_Id",
                        column: x => x.o_quantityo_Id,
                        principalTable: "orders",
                        principalColumn: "o_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_carts_o_quantityo_Id",
                table: "carts",
                column: "o_quantityo_Id");

            migrationBuilder.CreateIndex(
                name: "IX_carts_Off_Id1",
                table: "carts",
                column: "Off_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Off_Id1",
                table: "orders",
                column: "Off_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_orders_Pr_Id1",
                table: "orders",
                column: "Pr_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_products_Cat_Id1",
                table: "products",
                column: "Cat_Id1");

            migrationBuilder.CreateIndex(
                name: "IX_sproducts_Cat_Id1",
                table: "sproducts",
                column: "Cat_Id1");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cArticles");

            migrationBuilder.DropTable(
                name: "carts");

            migrationBuilder.DropTable(
                name: "catagories");

            migrationBuilder.DropTable(
                name: "displayDetails");

            migrationBuilder.DropTable(
                name: "hArticles");

            migrationBuilder.DropTable(
                name: "logins");

            migrationBuilder.DropTable(
                name: "sproducts");

            migrationBuilder.DropTable(
                name: "orders");

            migrationBuilder.DropTable(
                name: "offers");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "categories");
        }
    }
}
