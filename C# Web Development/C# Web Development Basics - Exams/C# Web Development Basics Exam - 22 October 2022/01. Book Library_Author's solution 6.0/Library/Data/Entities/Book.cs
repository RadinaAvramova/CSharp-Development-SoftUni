using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Data.DataConstants;

namespace Library.Data.Entities
{
    public class Book
    {
        public int Id { get; init; }

        [Required]
        [MaxLength(MaxBookTitle)]
        public string Title { get; set; }

        [Required]
        [MaxLength(MaxAuthorName)]
        public string Author { get; set; }

        [Required]
        [MaxLength(MaxDescription)]

        public string Description { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        [Column(TypeName = "decimal(4,2)")]
        public decimal Rating { get; set; }


        public Category Category { get; set; }

        public int CategoryId { get; set; }

        public ICollection<UserBook> UsersBooks { get; set; }
    }
}
