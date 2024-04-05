public class LibraryManager
{
    private readonly ILibraryService _libraryService;
    private readonly ILibraryUserInteraction _libraryUserInteraction;
    private readonly IMemberRepository _memberRepository;
    private readonly IBookRepository _bookRepository;


    public LibraryManager(ILibraryService libraryService, ILibraryUserInteraction libraryUserInteraction, IMemberRepository memberRepository, IBookRepository bookRepository)
    {
        _libraryService = libraryService;
        _libraryUserInteraction = libraryUserInteraction;
        _memberRepository = memberRepository;
        _bookRepository = bookRepository;
    }

    public void Run()
    {
        while (true)
        {
            _libraryUserInteraction.PromptToSelectOption();
            var userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":
                    Member member = _libraryUserInteraction.CreateMember();
                    _memberRepository.AddMember(member);
                    break;
                case "2":
                    _libraryUserInteraction.ShowMessage("\nEnter Member ID to remove.");
                    var memberId = Console.ReadLine();
                    _memberRepository.DeleteMember(memberId);
                    break;
                case "3":
                    Member updateMember = _libraryUserInteraction.CreateMember();
                    _memberRepository.UpdateMember(updateMember);
                    break;
                case "4":
                    Book updateBook = _libraryUserInteraction.CreateBook();
                    _bookRepository.UpdateBook(updateBook);
                    break;
                case "6":
                    _libraryUserInteraction.Exit();
                    break;
                default:
                    _libraryUserInteraction.ShowMessage("Invalid choice. Please choose again.");
                    break;
            }
        }
    }
}