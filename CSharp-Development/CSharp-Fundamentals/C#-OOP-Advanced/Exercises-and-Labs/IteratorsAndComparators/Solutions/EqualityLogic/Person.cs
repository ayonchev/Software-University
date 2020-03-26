using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

public class Person : IEquatable<Person>, IComparable<Person>
{
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string Name { get; private set; }
    public int Age { get; private set; }

    public bool Equals(Person other)
    {
        return this.GetHashCode().Equals(other.GetHashCode());
    }

    public int CompareTo(Person other)
    {
        if (this.Equals(other))
        {
            return 0;
        }

        int result = this.Name.CompareTo(other.Name);

        if (result == 0)
        {
            result = this.Age.CompareTo(other.Age);
        }

        return result;
    }

    public override int GetHashCode()
    {
        return this.Name.GetHashCode() * 17 + this.Age.GetHashCode();
    }
}
