public interface IBookRepository
{
    void AddBook(Book book);
    void DeleteBook(string bookId);
    void UpdateBook(Book book);
    void GetBook(string bookId);
}