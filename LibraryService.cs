public class LibraryService : ILibraryService
{
    const int DUEDATE = 14;
    private readonly IMemberRepository _memberRepository;
    private readonly IBookRepository _bookRepository;

    public LibraryService(IMemberRepository memberRepository, IBookRepository bookRepository)
    {
        _memberRepository = memberRepository;
        _bookRepository = bookRepository;
    }

    public void BorrowBook(string memberId, string bookId)
    {
        // Get member and book from repositories
        Member member = _memberRepository.GetMember(memberId);
        Book book = _bookRepository.GetBook(bookId);

        if (member == null || book == null)
        {
            // Invalid member ID or BOOK ID
            return;
        }

        if (!book.IsAvailable)
        {
            // Book is not available for borrrow
            return;
        }

        // Update book availability and due date
        book.IsAvailable = false;
        book.DueDate = DateTime.Now.AddDays(DUEDATE);
        // Add book to borrowed list
        member.BorrowedBooks.Add(book);

        // Save changes
        _memberRepository.UpdateMember(member);
        _bookRepository.UpdateBook(book);
    }

    public void ReturnBook(string memberId, string bookId)
    {
        // Get member and book from database
        Member member = _memberRepository.GetMember(memberId);
        Book book = _bookRepository.GetBook(bookId);

        if (member == null || book == null)
        {
            // Invalid member ID or BOOK ID
            return;
        }

        // Remove book from borrowed list
        member.BorrowedBooks.Remove(book);

        // Update book availability and due date
        book.IsAvailable = true;
        book.DueDate = DateTime.Now.AddDays(DUEDATE);

        // Save changes
        _memberRepository.UpdateMember(member);
        _bookRepository.UpdateBook(book);
    }

    public void CalculateFine(string memberId)
    {
        // Get member from database
        Member member = _memberRepository.GetMember(memberId);

        if (member == null)
        {
            // Invalid member ID
            return;
        }

        if (member.BorrowedBooks.Count == 0)
        {
            // Member has no borrowed books
            return;
        }

        // Calculate fine
        int fine = 0;
        foreach (Book book in member.BorrowedBooks)
        {
            if (book.DueDate < DateTime.Now)
            {
                fine += 10;
            }
        }

        // Update member fine
        member.Fine = fine;

        // Save changes
        _memberRepository.UpdateMember(member);
    }
}