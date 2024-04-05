public class LibraryUserInteraction : ILibraryUserInteraction
{
    public Book CreateBook()
    {
        Book newBook = new Book();
        Console.Write("\nEnter Book Id: ");
        newBook.BookId = Console.ReadLine();
        Console.Write("\nEnter Book Title: ");
        newBook.Title = Console.ReadLine();
        Console.WriteLine("\nEnter Book Author: ");
        newBook.Author = Console.ReadLine();
        return newBook;
    }

    public Member CreateMember()
    {
        Member newMember = new();
        Console.Write("\nEnter Member Id: ");
        newMember.MemberId = Console.ReadLine();
        Console.Write("\nEnter Member Name: ");
        newMember.Name = Console.ReadLine();
        Console.Write("\nEnter Member Address: ");
        newMember.Address = Console.ReadLine();
        Console.Write("\nEnter Member Phone Number: ");
        newMember.PhoneNumber = Convert.ToInt64(Console.ReadLine());
        return newMember;
    }

    public void Exit()
    {
        Console.WriteLine("Exiting...");
        Thread.Sleep(1000);
        Environment.Exit(0);
    }

    public void PromptToSelectOption()
    {
        Console.WriteLine("\nLibrary Management System");
        Console.WriteLine("1. Add Member");
        Console.WriteLine("2. Delete Member");
        Console.WriteLine("1. Add Book");
        Console.WriteLine("2. Delete Book");
        Console.WriteLine("3. Update Member");
        Console.WriteLine("4. Update Book");
        Console.WriteLine("6. Exit");

        Console.Write("\nEnter your choice: ");
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
        Thread.Sleep(1000);
    }
}