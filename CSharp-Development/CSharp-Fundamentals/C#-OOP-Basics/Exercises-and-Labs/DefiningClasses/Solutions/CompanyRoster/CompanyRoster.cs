using System;
using System.Collections.Generic;
using System.Linq;

public class CompanyRoster
{
    static void Main()
    {
        int numberOfEmployees = int.Parse(Console.ReadLine());

        Dictionary<string, List<Employee>> departments = new Dictionary<string, List<Employee>>();

        for (int i = 0; i < numberOfEmployees; i++)
        {
            string[] currentEmployeeData = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);


            string employeeName = currentEmployeeData[0];
            double employeeSalary = double.Parse(currentEmployeeData[1]);
            string employeePosition = currentEmployeeData[2];
            string employeeDepartment = currentEmployeeData[3];

            Employee currentEmployee = new Employee(employeeName, employeeSalary, employeePosition);
            switch (currentEmployeeData.Length)
            {
                case 5:
                    if (char.IsDigit(currentEmployeeData[4][0]))
                    {
                        currentEmployee = new Employee(employeeName, employeeSalary, employeePosition, int.Parse(currentEmployeeData[4]));
                    }
                    else
                    {
                        currentEmployee = new Employee(employeeName, employeeSalary, employeePosition, currentEmployeeData[4]);
                    }
                    break;
                case 6:
                    currentEmployee = new Employee(employeeName, employeeSalary, employeePosition, currentEmployeeData[4], int.Parse(currentEmployeeData[5]));
                    break;
            }

            if (!departments.ContainsKey(employeeDepartment))
            {
                departments.Add(employeeDepartment, new List<Employee>());
            }
            departments[employeeDepartment].Add(currentEmployee);
        }

        foreach (var department in departments.OrderByDescending(x => x.Value.Average(e => e.Salary)))
        {
            Console.WriteLine($"Highest Average Salary: {department.Key}");

            foreach (var employee in department.Value.OrderByDescending(x => x.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
            break;
        }
    }
}

