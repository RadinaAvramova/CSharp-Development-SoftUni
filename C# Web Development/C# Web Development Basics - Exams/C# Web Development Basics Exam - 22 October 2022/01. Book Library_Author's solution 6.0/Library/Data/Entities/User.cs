using Microsoft.AspNetCore.Identity;

namespace Library.Data.Entities
{
    public class User : IdentityUser
    {
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
