using Microsoft.EntityFrameworkCore;
using Final_Project_API.Models;

namespace Final_Project_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<Hobby> Hobbies { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Pet> Pets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TeamMember>().HasData(
                new TeamMember
                {
                    ID = 1,
                    FullName = "Nick Hosler",
                    BirthDate = new DateTime(2003, 2, 04),
                    CollegeProgram = "Information Technology",
                    YearInProgram = "Sophomore",
                    FavoriteLanguage = "C#",
                    Hometown = "Cincinnati"
                }
            );

            modelBuilder.Entity<Hobby>().HasData(
                new Hobby
                {
                    Id = 1,
                    Name = "Gaming",
                    Type = "Action",
                    DifficultyLevel = 2,
                    EquipmentNeeded = "Console, Game, Controller",
                    HoursPerWeek = 6
                },
                new Hobby
                {
                    Id = 2,
                    Name = "Bicycling",
                    Type = "Fitness",
                    DifficultyLevel = 4,
                    EquipmentNeeded = "Bicycle",
                    HoursPerWeek = 6
                }
            );


            modelBuilder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "1984",
                    Author = "George Orwell",
                    Genre = "Dystopian",
                    YearPublished = "1949",
                    IsHardcover = true
                }
            );

            modelBuilder.Entity<Pet>().HasData(
                new Pet
                {
                    Id = 1,
                    Name = "Buddy",
                    Species = "Dog",
                    Age = 4,
                    FavoriteToy = "Ball",
                    IsVaccinated = true
                }
            );
        }
    }
}
