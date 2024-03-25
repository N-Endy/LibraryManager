public interface IMemberRepository
{
    void AddMember(Member member);
    void DeleteMember(string memberId);
    void UpdateMember(Member member);
    Member GetMember(string memberId);
}