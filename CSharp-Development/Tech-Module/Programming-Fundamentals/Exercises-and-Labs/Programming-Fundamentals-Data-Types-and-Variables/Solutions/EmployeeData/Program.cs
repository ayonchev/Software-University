using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeData
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char sex = char.Parse(Console.ReadLine());
            long persID = long.Parse(Console.ReadLine());
            int employeeNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Last name: " + secondName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Gender: " + sex);
            Console.WriteLine("Personal ID: " + persID);
            Console.WriteLine("Unique Employee number: " + employeeNumber);
        }
    }
}
