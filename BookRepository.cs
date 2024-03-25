public class BookRepository : IBookRepository
{
    private readonly List<Book> _books = new();
    public void AddBook(Book book)
    {
        _books.Add(book);
    }

    public void DeleteBook(string bookId)
    {
        var bookToRemove = _books.FirstOrDefault(book => book.BookId == bookId);
        if (bookToRemove != null)
            _books.Remove(bookToRemove);
        // Else tell user bok doesn't exist.
    }

    public void GetBook(string bookId)
    {
        var bookToBeGotten = _books.FirstOrDefault(book => book.BookId == bookId);
        if (bookToBeGotten != null){}
            // Show te book to be displayed
        // Else tell user that BookId is incorrect.
    }

    public void UpdateBook(Book book)
    {
        var bookToBeUpdated = _books.FirstOrDefault(b => b.BookId == book.BookId);

        if (bookToBeUpdated != null)
        {
            bookToBeUpdated.BookId = book.BookId;
            bookToBeUpdated.Title = book.Title;
            bookToBeUpdated.Author = book.Author;
            bookToBeUpdated.Genre = book.Genre;
            bookToBeUpdated.Description = book.Description;
            bookToBeUpdated.IsAvailable = book.IsAvailable;
            bookToBeUpdated.DueDate = book.DueDate;
        }
        // Else, tell user the id for book is incorrect.
    }
}