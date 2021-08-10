using Microsoft.EntityFrameworkCore.Migrations;

namespace EssentialStore.Migrations
{
    public partial class EssentialGrocery : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Import",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    BDate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Import", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Sale",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    BDate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sale", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Stock",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Product = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    importid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stock", x => x.id);
                    table.ForeignKey(
                        name: "FK_Stock_Import_importid",
                        column: x => x.importid,
                        principalTable: "Import",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stock_importid",
                table: "Stock",
                column: "importid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sale");

            migrationBuilder.DropTable(
                name: "Stock");

            migrationBuilder.DropTable(
                name: "Import");
        }
    }
}
