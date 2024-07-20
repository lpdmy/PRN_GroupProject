using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class AddproductData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "Description", "ImagePath", "Price", "ProductName", "UnitInStock" },
                values: new object[,]
                {
                    { 1, 1, "Hamburger with cheese and beefsteak", "/Img/hamburger.jpg", 10.0, "VIP Hamburger", 100 },
                    { 2, 1, "Pizza with cheese and beefsteak", "/Img/pizza.jpg", 50.0, "VIP Pizza", 200 },
                    { 3, 2, "Sushi is fresh", "/Img/sushi.jpg", 100.0, "Golden Sushi", 150 },
                    { 4, 2, "Sashimi is fresh too", "/Img/sashimi.jpg", 60.0, "Golden Sashimi", 150 },
                    { 5, 2, "Very very big sukiyaki", "/Img/sukiyaki.jpg", 150.0, "Sukiyaki Hotpot", 150 },
                    { 6, 3, "Very very big sukiyaki", "/Img/coca.jpg", 15.0, "Sukiyaki Hotpot", 150 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);
        }
    }
}
