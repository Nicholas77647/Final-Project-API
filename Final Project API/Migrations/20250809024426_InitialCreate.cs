using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Final_Project_API.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Author = table.Column<string>(type: "TEXT", nullable: false),
                    Genre = table.Column<string>(type: "TEXT", nullable: false),
                    YearPublished = table.Column<string>(type: "TEXT", nullable: false),
                    IsHardcover = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    DifficultyLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    EquipmentNeeded = table.Column<string>(type: "TEXT", nullable: false),
                    HoursPerWeek = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Species = table.Column<string>(type: "TEXT", nullable: false),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    FavoriteToy = table.Column<string>(type: "TEXT", nullable: false),
                    IsVaccinated = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FullName = table.Column<string>(type: "TEXT", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CollegeProgram = table.Column<string>(type: "TEXT", nullable: false),
                    YearInProgram = table.Column<string>(type: "TEXT", nullable: false),
                    FavoriteLanguage = table.Column<string>(type: "TEXT", nullable: false),
                    Hometown = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "IsHardcover", "Title", "YearPublished" },
                values: new object[] { 1, "George Orwell", "Dystopian", true, "1984", "1949" });

            migrationBuilder.InsertData(
                table: "Pets",
                columns: new[] { "Id", "Age", "FavoriteToy", "IsVaccinated", "Name", "Species" },
                values: new object[] { 1, 4, "Ball", true, "Buddy", "Dog" });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "ID", "BirthDate", "CollegeProgram", "FavoriteLanguage", "FullName", "Hometown", "YearInProgram" },
                values: new object[] { 1, new DateTime(2003, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Information Technology", "C#", "Nick Hosler", "Cincinnati", "Sophomore" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Pets");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
