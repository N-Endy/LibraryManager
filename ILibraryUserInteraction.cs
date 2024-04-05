public interface ILibraryUserInteraction
{
    void ShowMessage(string message);
    void Exit();
    void PromptToSelectOption();
    Member CreateMember();
    Book CreateBook();
}