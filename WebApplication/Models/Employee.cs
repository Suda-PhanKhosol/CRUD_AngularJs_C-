using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication.Models
{
    public partial class Employee
    {
        public string En { get; set; }
        public string Name { get; set; }
        public int DepartmentId { get; set; }
        public int? Age { get; set; }
        public double? Salary { get; set; }
        public string Alive { get; set; }

        public virtual Department Department { get; set; }
    }
}
