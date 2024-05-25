namespace Library.Models.Books
{
    public class AllBooksQueryModel
    {
        public IEnumerable<BookDetailsViewModel> Books { get; set; }
          = new List<BookDetailsViewModel>();
    }
}
