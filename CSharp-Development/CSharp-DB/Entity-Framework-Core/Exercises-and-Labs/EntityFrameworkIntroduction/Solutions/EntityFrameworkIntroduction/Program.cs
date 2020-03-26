using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EntityFrameworkIntroduction.Data;
using EntityFrameworkIntroduction.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SoftUniContext db = new SoftUniContext())
            {
                //----Employees And Projects----

                /*var employees = db.Employees
                    .Where(e => 
                        e.EmployeesProjects
                        .Any(ep =>
                            ep.Project.StartDate.Year >= 2001 &&
                            ep.Project.StartDate.Year <= 2003
                            )
                        )
                        .Take(30)
                        .Select(e => new
                        {
                            Name = $"{e.FirstName} {e.LastName}",
                            ManagerName = $"{e.Manager.FirstName} {e.Manager.LastName}",
                            Projects = e.EmployeesProjects.Select(ep => ep.Project)
                        })
                    .ToList();

                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.Name} - Manager: {employee.ManagerName}");

                    foreach (var project in employee.Projects)
                    {
                        Console.WriteLine($"--{project.Name} - " +
                                          $"{project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)} - " +
                                          $"{(project.EndDate != null ? project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) : "not finished")}");
                    }
                }*/

                //----Addresses By Town----

                /*var addresses = db.Addresses
                    .Select(a => new
                    {
                        Text = a.AddressText,
                        TownName = a.Town.Name,
                        EmployeeCount = a.Employees.Count
                    })
                    .OrderByDescending(a => a.EmployeeCount)
                    .ThenBy(a => a.TownName)
                    .ThenBy(a => a.Text)
                    .Take(10)
                    .ToList();

                foreach (var address in addresses)
                {
                    Console.WriteLine($"{address.Text}, {address.TownName} - {address.EmployeeCount} employees");
                }*/

                //----Employee 147----

                /*var employeeWithId = db.Employees
                    .Select(e => new
                    {
                        e.EmployeeId,
                        Name = $"{e.FirstName} {e.LastName}",
                        e.JobTitle,
                        Projects = e.EmployeesProjects.Select(ep => ep.Project)
                    })
                    .SingleOrDefault(e => e.EmployeeId == 147);

                Console.WriteLine($"{employeeWithId.Name} - {employeeWithId.JobTitle}");
                foreach (var project in employeeWithId.Projects.OrderBy(e => e.Name))
                {
                    Console.WriteLine(project.Name);
                }*/

                //----Departments with More Than 5 Employees----

                /*var departments = db.Departments
                    .Where(d => d.Employees.Count > 5)
                    .Select(d => new
                    {
                        d.Name,
                        ManagerName = $"{d.Manager.FirstName} {d.Manager.LastName}",
                        d.Employees
                    })
                    .ToList();

                foreach (var department in departments.OrderBy(d => d.Employees.Count).ThenBy(d => d.Name))
                {
                    Console.WriteLine($"{department.Name} - {department.ManagerName}");

                    foreach (var employee in department.Employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
                    {
                        Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                    }

                    Console.WriteLine("----------");
                }*/

                //----Find Latest 10 Projects----

                /*var projects = db.Projects
                    .OrderByDescending(p => p.StartDate)
                    .Take(10)
                    .OrderBy(p => p.Name)
                    .ToList();

                foreach (var project in projects)
                {
                    Console.WriteLine(project.Name);
                    Console.WriteLine(project.Description);
                    Console.WriteLine(project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture));
                }*/

                //----12.	Increase Salaries----

                /*var employees = db.Employees
                    .Where(e => e.FirstName.StartsWith("Sa"))
                    .ToList();

                foreach (var employee in employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle} - (${employee.Salary:F2})");
                }

                db.SaveChanges();*/

                //----14.	Delete Project by Id----
                /*var projectId = 2;
                var empProjects = db.EmployeesProjects.Where(ep => ep.ProjectId == projectId).ToList();

                foreach (var employeeProject in empProjects)
                {
                    db.EmployeesProjects.Remove(employeeProject);
                }

                var project = db.Projects.Find(projectId);
                db.Projects.Remove(project);

                db.SaveChanges();
                foreach (var p in db.Projects.Take(10).ToList())
                {
                    Console.WriteLine(p.Name);   
                }*/

                //

                //Select clause actually converts all the entities in the collection from type Project to a' (anonymous). Thats the magic behind using only the properties that i want when working with dbsets. I think that when creating new object we actually pass the constructor to the method and the constructor gives us the new object. And that's why we can pass 'Objects' to the Select. We actually pass a Func that takes a Project and returns an Employee or otherwise said we pass the constructor.
                Project[] projectArr = new Project[10];
                var newAnonymousArr = projectArr.Select(p => new { Name = p.Name, p.EmployeesProjects }).ToList();
                var newEmployeesArr = projectArr.Select(p => new Employee() { EmployeeId = p.ProjectId }).ToList();
                projectArr.Select((p, index) => new { Message = $"Here is {p.Name} at {index}" });
                Func<Project, object> myFunc = delegate (Project obj)
                {
                    return int.Parse(obj.Name);
                };

                List<int> numbers = new List<int> { 3, 6, 8, 9, 12 };
                numbers.Select((num, index) => new { Position = $"The number {num} is at position {index}" }).ToList().ForEach(num => Console.WriteLine(num.Position));

                List<string> numbersInString = new List<string> {"1", "2", "3", "9"};
                numbersInString.Select(n => int.Parse(n)).ToList().ForEach(n => Console.WriteLine(n));
                numbersInString.Select(int.Parse).ToList().ForEach(n => Console.WriteLine(n));
            }
        }
    }
}
