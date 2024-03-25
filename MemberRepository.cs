public class MemberRepository : IMemberRepository
{
    private readonly List<Member> _members = new();
    public void AddMember(Member member)
    {
        _members.Add(member);
    }

    public void DeleteMember(string memberId)
    {
        var memberToBeDeleted = _members.FirstOrDefault(m => m.MemberId == memberId);
    }

    public Member GetMember(string memberId)
    {
        var memberToBeGotten = _members.FirstOrDefault(m => m.MemberId == memberId);

        if (memberToBeGotten != null){}
            // Display the member
        // Else, alert the user that the memberId is incorrect.

        return memberToBeGotten;
    }

    public void UpdateMember(Member member)
    {
        var memberToBeUpdated = _members.FirstOrDefault(m => m.MemberId == member.MemberId);

        if (memberToBeUpdated != null)
        {
            memberToBeUpdated.Name = member.Name;
            memberToBeUpdated.Address = member.Address;
            memberToBeUpdated.PhoneNumber = member.PhoneNumber;
        }
    }
}