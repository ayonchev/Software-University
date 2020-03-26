using System;

public class Program
{
    static void Main()
    {
        Person newPerson = new Person(5);
        Console.WriteLine(newPerson.Age);
    }

    internal class Person
    {
        public Person(int age)
        {
            this.Age = age;
        }
        private int age;

        public int Age
        {
            get { return age; }
            set { age = value * 2; }
        }

    }
}
