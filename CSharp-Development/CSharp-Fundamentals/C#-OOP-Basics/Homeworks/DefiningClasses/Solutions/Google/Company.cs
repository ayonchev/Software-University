using System;
using System.Collections.Generic;
using System.Text;

public class Company
{
    private string name;
    private string department;
    private double salary;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public string Department
    {
        get { return this.department; }
        set { this.department = value; }
    }

    public double Salary
    {
        get { return this.salary; }
        set { this.salary = value; }
    }

    public Company()
    {
        
    }

    public Company(string currentName, string currentDepartment, double currentSalary)
    {
        this.name = currentName;
        this.department = currentDepartment;
        this.salary = currentSalary;
    }

    public override string ToString()
    {
        if (this.name == null)
        {
            return string.Empty;
        }
        return $"{this.name} {this.department} {this.salary:F2}\r\n";
    }
}
