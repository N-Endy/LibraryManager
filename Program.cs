IBookRepository bookRepository = new BookRepository();
IMemberRepository memberRepository = new MemberRepository();
ILibraryUserInteraction libraryUserInteraction = new LibraryUserInteraction();
ILibraryService libraryService = new LibraryService(memberRepository, bookRepository);

var libraryManager = new LibraryManager(libraryService, libraryUserInteraction, memberRepository, bookRepository);

libraryManager.Run();