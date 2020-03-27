using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Family
{
    private List<Person> familyMembers;

    public Family()
    {
        this.familyMembers = new List<Person>();
    }

    public List<Person> FamilyMembers
    {
        get { return this.familyMembers; }
        set { this.familyMembers = value; }
    }

    public void AddMember(Person member)
    {
        this.familyMembers.Add(member);
    }

    public List<Person> GetOlderThan30()
    {
        return this.familyMembers.Where(x => x.Age > 30).ToList();
    }

    public Person GetOldestMember()
    {
        return this.familyMembers.OrderByDescending(x => x.Age).FirstOrDefault();
    }
}
