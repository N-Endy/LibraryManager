/* The class "Book" represents a book entity with properties */
public class Book
{
    public string BookId { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Genre { get; set;}
    public string Description { get; set; }
    public bool IsAvailable { get; set; }
    public DateTime DueDate { get; set; }
}