﻿namespace Final_Project_API.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Species { get; set; }
        public int Age { get; set; }
        public string FavoriteToy { get; set; }
        public bool IsVaccinated { get; set; }
    }
}
