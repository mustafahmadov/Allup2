using Microsoft.EntityFrameworkCore.Migrations;

namespace Allup.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "HasDeleted", "Image", "IsMain", "Name", "ParentId" },
                values: new object[,]
                {
                    { 1, false, "category-1.jpg", true, "Laptop", null },
                    { 2, false, "category-2.jpg", true, "Computer", null },
                    { 3, false, "category-3.jpg", true, "Smartphone", null },
                    { 4, false, "category-4.jpg", true, "Game Console", null },
                    { 5, false, "category-5.jpg", true, "Bottoms", null },
                    { 6, false, "category-6.jpg", true, "Tops&Sets", null },
                    { 7, false, "category-7.jpg", true, "Audio&Video", null },
                    { 8, false, "category-8.jpg", true, "Accessories", null },
                    { 9, false, "category-9.jpg", true, "Camera", null },
                    { 10, false, "category-10.jpg", true, "Video Games", null },
                    { 11, false, "category-11.jpg", true, "Printer", null },
                    { 12, false, "category-12.jpg", true, "Headphones", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);
        }
    }
}
