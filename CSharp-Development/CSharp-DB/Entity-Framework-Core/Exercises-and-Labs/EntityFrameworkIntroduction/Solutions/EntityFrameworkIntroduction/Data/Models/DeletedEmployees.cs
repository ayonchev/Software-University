using System;
using System.Collections.Generic;

namespace EntityFrameworkIntroduction.Data.Models
{
    public partial class DeletedEmployees
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string JobTitle { get; set; }
        public int DepartmendId { get; set; }
        public decimal Salary { get; set; }
    }
}
