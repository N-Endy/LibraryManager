public class LibraryManager
{
    private readonly ILibraryService _libraryService;
    private readonly ILibraryUserInteraction _libraryUserInteraction;
    private readonly IMemberRepository _memberRepository;

    public LibraryManager(ILibraryService libraryService, ILibraryUserInteraction libraryUserInteraction, IMemberRepository memberRepository)
    {
        _libraryService = libraryService;
        _libraryUserInteraction = libraryUserInteraction;
        _memberRepository = memberRepository;
    }

    public void Run()
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
                _libraryUserInteraction.ShowMessage("\nThis update is coming soon.");
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