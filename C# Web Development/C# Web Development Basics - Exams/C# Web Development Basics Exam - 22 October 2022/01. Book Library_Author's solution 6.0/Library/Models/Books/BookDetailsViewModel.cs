using Library.Data.Entities;
using Microsoft.AspNetCore.Identity;

namespace Library.Models.Books
{
    public class BookDetailsViewModel
    {
        public int Id { get; init; }

        public string ImageUrl { get; init; }

        public string Title { get; init; }

        public string Author { get; init; }

        public string Rating { get; init; }
        
        public string Category { get; set; }

        public string Description { get; set; }

    }
}
