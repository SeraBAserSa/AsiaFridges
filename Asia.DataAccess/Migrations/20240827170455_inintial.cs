using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AsiaFridges.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class inintial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FridgeTypes",
                columns: table => new
                {
                    FridgeTypeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FridgeTypeName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FridgeTypes", x => x.FridgeTypeID);
                });

            migrationBuilder.InsertData(
                table: "FridgeTypes",
                columns: new[] { "FridgeTypeID", "DisplayOrder", "FridgeTypeName" },
                values: new object[,]
                {
                    { 1, 1, "Top Freezer" },
                    { 2, 2, "Bottom Freezer" },
                    { 3, 3, "Side-by-Side" },
                    { 4, 4, "Mini Fridge" },
                    { 5, 5, "Wine Cooler" },
                    { 6, 6, "Bar Fridge" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FridgeTypes");
        }
    }
}
