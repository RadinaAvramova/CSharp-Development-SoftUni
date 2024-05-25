using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Entities
{
    public class UserBook
    {
        [ForeignKey("User")]
        public string CollectorId { get; set; }

        public User Collector { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
