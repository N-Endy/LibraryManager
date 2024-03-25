public class LibraryService : ILibraryService
{
    private readonly IMemberRepository _memberRepository;
    private readonly IBookRepository _bookRepository;

    public LibraryService(IMemberRepository memberRepository, IBookRepository bookRepository)
    {
        _memberRepository = memberRepository;
        _bookRepository = bookRepository;
    }

    public void BorrowBook(string memberId, string bookId)
    {
        Member member = _memberRepository.GetMember(memberId);
    }

    public void CalculateFine(string memberId)
    {
        throw new NotImplementedException();
    }

    public void ReturnBook(string memberId, string bookId)
    {
        throw new NotImplementedException();
    }
}