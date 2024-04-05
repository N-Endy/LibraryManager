/* The class "Member" represents a member with properties  */
public class Member
{
    public string MemberId { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public long PhoneNumber { get; set; }
    public List<Book> BorrowedBooks { get; set; }

    public int Fine {get; set;}
}