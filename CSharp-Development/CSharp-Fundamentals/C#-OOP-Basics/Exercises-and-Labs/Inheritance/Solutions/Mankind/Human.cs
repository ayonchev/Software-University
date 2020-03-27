using System;
using System.Collections.Generic;
using System.Text;

public class Human
{
    private string firstName;
    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public string FirstName
    {
        get { return firstName; }
        set
        {
            ValidateName(value, "firstName");
            firstName = value;
        }
    }

    public string LastName
    {
        get { return lastName; }
        set
        {
            ValidateName(value, "lastName");
            lastName = value;
        }
    }

    private void ValidateName(string name, string type)
    {
        if (!Char.IsUpper(name[0]))
        {
            throw new ArgumentException($"Expected upper case letter! Argument: {type}");
        }

        if (name.Length < 4 && type == "firstName")
        {
            throw new ArgumentException($"Expected length at least 4 symbols! Argument: {type}");
        }
        else if (name.Length < 3 && type == "lastName")
        {
            throw new ArgumentException($"Expected length at least 3 symbols! Argument: {type}");
        }
    }

    public override string ToString()
    {
        return $"First Name: {this.FirstName}\n" +
                      $"Last Name: {this.LastName}\n";
    }
}
