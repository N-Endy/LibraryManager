public interface ILibraryService
{
    void BorrowBook(string memberId, string bookId);
    void ReturnBook(string memberId, string bookId);
    void CalculateFine(string memberId);
}