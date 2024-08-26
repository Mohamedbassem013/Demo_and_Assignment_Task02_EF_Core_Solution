using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session_02_EF_Core.Entities
{
    internal class Employee
    {
        public int Id { get; set; } // PK --> EmployeeId.Identity (1,1)
        public string Name { get; set; } // nvarchar(max)
        public double? Salary { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        [InverseProperty(nameof(Department.Manager))]
        public Department departments { get; set; }

        public int? Workfor { get; set; } // FK

        [InverseProperty(nameof(Department.EmployeeId))]
        public Department? WorkFor { get; set; }
    }
}
