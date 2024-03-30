
namespace BookStoreProject.Models
{
    public class EFBookRepository(BookstoreContext temp) : IBookRepository
    {
        private readonly BookstoreContext _context = temp;

        public IQueryable<Book> Books => _context.Books;
    }
}
