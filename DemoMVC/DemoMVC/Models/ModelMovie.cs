using System;

using System.Data.Entity;

namespace MvcMovie.Models
{
    public class ModelMovie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string Genre { get; set; }
        public decimal Price { get; set; }
    }

    public class MovieDBContext : DbContext
    {
        public DbSet<ModelMovie> Movies { get; set; }
    }

}