using System;
using System.Collections.Generic;
using System.Text;

public class Worker : Human
{
    private decimal weekSalary;
    private decimal workHours;
    private decimal salaryPerHour;

    public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay)
        : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.WorkHours = workHoursPerDay;
        this.salaryPerHour = WeekSalary / (WorkHours * 5);
    }

    public decimal WeekSalary
    {
        get { return weekSalary; }
        set
        {
            if (value <= 10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            weekSalary = value;
        }
    }

    public decimal WorkHours
    {
        get { return workHours; }
        set
        {
            if (value < 1 || value > 12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            workHours = value;
        }
    }

    public override string ToString()
    {
        return base.ToString() +
               $"Week Salary: {this.WeekSalary:F2}\n" +
               $"Hours per day: {this.WorkHours:F2}\n" +
               $"Salary per hour: {this.salaryPerHour:F2}";
    }
}
