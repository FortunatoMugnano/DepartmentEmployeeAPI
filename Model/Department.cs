using DepartmentExample.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DepartmentExample.Model
{
    public class Department
    {

        public int Id { get; set; }
        public string DeptName { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();

        
    }
}
