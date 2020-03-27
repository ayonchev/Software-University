using System;
using System.Collections.Generic;
using System.Text;

public class Employee
{
    private string name;
    private double salary;
    private string position;
    private string email;
    private int age;

    public string Name
    {
        get { return this.name; }
    }
    public int Age
    {
        get { return this.age; }
    }
    public double Salary
    {
        get { return this.salary; }
    }
    public string Position
    {
        get { return this.position; }
    }

    public string Email
    {
        get { return this.email; }
    }
    public Employee(string name, double salary, string position)
    {
        this.name = name;
        this.salary = salary;
        this.position = position;
        this.age = -1;
        this.email = "n/a";
    }

    public Employee(string name, double salary, string position, string email) : this(name, salary, position)
    {
        this.email = email;
    }

    public Employee(string name, double salary, string position, int age) : this(name, salary, position)
    {
        this.age = age;
    }

    public Employee(string name, double salary, string position, string email, int age) : this(name, salary, position, email)
    {
        this.age = age;
    }
}

