using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Final_Project_API.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Id", "DifficultyLevel", "EquipmentNeeded", "HoursPerWeek", "Name", "Type" },
                values: new object[,]
                {
                    { 1, 2, "Console, Game, Controller", 6, "Gaming", "Action" },
                    { 2, 4, "Bicycle", 6, "Bicycling", "Fitness" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Hobbies",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
