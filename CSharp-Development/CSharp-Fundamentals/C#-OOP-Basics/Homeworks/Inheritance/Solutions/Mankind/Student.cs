using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public string FacultyNumber
    {
        get { return facultyNumber; }
        set
        {
            if ((value.Length < 5 || value.Length > 10) || !Regex.IsMatch(value.Trim(), @"^[A-Za-z0-9]+$"))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            facultyNumber = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() +
               $"Faculty number: {this.FacultyNumber}\n";
    }
}
