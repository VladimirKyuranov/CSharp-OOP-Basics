using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Family
{
    private List<Person> familyMembers;

    public List<Person> FamilyMembers
    {
        get { return familyMembers; }
        set { familyMembers = value; }
    }

    public Family()
    {
        familyMembers = new List<Person>();
    }

    public void AddMember(Person member)
    {
        familyMembers.Add(member);
    }

    public Person GetOldestMember()
    {
        return familyMembers.Where(p => p.Age == familyMembers.Max(f => f.Age)).ToList()[0];
    }
}