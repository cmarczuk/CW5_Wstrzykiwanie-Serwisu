using Microsoft.EntityFrameworkCore.Migrations;

namespace CW5_Wstrzykiwanie_Serwisu.Migrations
{
    public partial class InitSchema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Id_json = table.Column<string>(nullable: true),
                    Maker = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Image = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Url = table.Column<string>(type: "varchar(99)", maxLength: 99, nullable: true),
                    Title = table.Column<string>(type: "varchar(99)", maxLength: 99, nullable: true),
                    Description = table.Column<string>(type: "varchar(99)", maxLength: 99, nullable: true),
                    ProductId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_ProductId",
                table: "Product",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}
