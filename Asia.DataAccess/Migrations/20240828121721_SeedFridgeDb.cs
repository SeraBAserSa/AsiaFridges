using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AsiaFridges.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class SeedFridgeDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fridges",
                columns: table => new
                {
                    FridgeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FridgeModel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FridgeDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FridgeCapacity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    FridgeStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fridges", x => x.FridgeID);
                });

            migrationBuilder.InsertData(
                table: "Fridges",
                columns: new[] { "FridgeID", "FridgeCapacity", "FridgeDescription", "FridgeModel", "FridgeStatus", "Price" },
                values: new object[,]
                {
                    { 1, 350, "Samsung Refrigerator ,stainless steel finish.", "RT38K5982SL", "Available", 8499.9899999999998 },
                    { 2, 400, "LG Bottom Freezer ,cooling efficiency.", "LFC25760SW", "Available", 3499.9899999999998 },
                    { 3, 500, "Side by Side , with ice maker.", "GSS25GSHSS", "Under Maintenance", 12999.99 },
                    { 4, 150, "Whirlpool, ideal for small space.", "Mini  WRT312CZJW", "Available", 2499.9899999999998 },
                    { 5, 100, "Wine Enthusiast ,with temperature settings.", "Wine Cooler 272 03 03", "Available", 5299.9899999999998 },
                    { 6, 80, "Frigidaire ,for beverages .", "Bar  EFR492", "In Transit", 3699.9899999999998 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fridges");
        }
    }
}
