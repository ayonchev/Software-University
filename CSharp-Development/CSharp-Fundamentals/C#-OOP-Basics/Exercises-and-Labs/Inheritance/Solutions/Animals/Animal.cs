using System;
using System.Collections.Generic;
using System.Text;

public class Animal
{
    private string name;
    private int age;
    private string gender;

    protected Animal(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public Animal(string name, int age, string gender):this(name, age)
    {
        this.Gender = gender;
    }

    public string Name
    {
        get { return name; }
        set
        {
            if (value == null || value.Trim() == String.Empty)
            {
                throw new ArgumentException("Invalid input!");
            }
            name = value;
        }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || String.IsNullOrEmpty(value.ToString()))
            {
                throw new ArgumentException("Invalid input!");
            }
            age = value;
        }
    }

    public virtual string Gender
    {
        get { return gender; }
        set
        {
            if (value == String.Empty || value == null || (value.ToLower() != "male" && value.ToLower() != "female"))
            {
                throw new ArgumentException("Invalid input!");
            }
            gender = value;
        }
    }

    public virtual string ProduceSound()
    {
        return string.Empty;
    }

    public override string ToString()
    {
        return $"{this.GetType()}\n" +
               $"{this.name} {this.age} {this.gender}\n" +
               this.ProduceSound();
    }
}