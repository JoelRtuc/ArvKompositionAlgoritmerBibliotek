using ArvKompositionAlgoritmerBibliotek;
using System;

public class Member : ISearchable
{
    string memberId { get; }//detta är ett annat sätt att göra readonly
    public string memberName { get; set; }
    string email { get; set; }
    public DateTime memberSince { get; set; }
    public List<Loan> loans = new List<Loan>(); 

    public Member(string memberId, string memberName, string email, DateTime memberSince)
    {
        this.memberId = memberId;
        this.memberName = memberName;
        this.email = email;
        this.memberSince = memberSince;
    }

    public void MembersInfo()
    {
        Console.WriteLine($"ID: {memberId}, Name: {memberName}, Email: {email}, Member Since: {memberSince}");
    }

    public bool Matches(string searchItem)
    {
        if (memberId.Contains(searchItem) || memberName.Contains(searchItem))
        {
            return true;
        }
        return false;
    }
}
