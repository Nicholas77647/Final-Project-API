namespace Final_Project_API.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string YearPublished { get; set; }
        public bool IsHardcover { get; set; }
    }
}
