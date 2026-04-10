using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyInventory2026.Migrations
{
    /// <inheritdoc />
    public partial class productMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    code_inv = table.Column<string>(type: "varchar(10)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    name_product = table.Column<string>(type: "varchar(50)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    stock = table.Column<int>(type: "int", nullable: false),
                    stock_min = table.Column<int>(type: "int", nullable: false),
                    stock_max = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "varchar(200)", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.id);
                    table.CheckConstraint("CK_products_stock", "stock > 0");
                    table.CheckConstraint("CK_products_stock_max", "stock_max > stock_min");
                    table.CheckConstraint("CK_products_stock_min", "stock_min > 0");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ProductProviders",
                columns: table => new
                {
                    Productsid = table.Column<int>(type: "int", nullable: false),
                    ProvidersId = table.Column<string>(type: "varchar(64)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductProviders", x => new { x.Productsid, x.ProvidersId });
                    table.ForeignKey(
                        name: "FK_ProductProviders_products_Productsid",
                        column: x => x.Productsid,
                        principalTable: "products",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductProviders_providers_ProvidersId",
                        column: x => x.ProvidersId,
                        principalTable: "providers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_ProductProviders_ProvidersId",
                table: "ProductProviders",
                column: "ProvidersId");

            migrationBuilder.CreateIndex(
                name: "IX_products_codeInv",
                table: "products",
                column: "code_inv",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductProviders");

            migrationBuilder.DropTable(
                name: "products");
        }
    }
}
