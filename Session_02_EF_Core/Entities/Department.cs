using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session_02_EF_Core.Entities
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }

        public int Employee { get; set; }

        // Fk لو عاوزه يعرف ان ده ال
       // [ForeignKey(nameof(Department.Manager))]
        public int EmployeeId { get; set; } // FK =>بتاعه manager بس لازم اسمه يكون نفس اسم الكلاس او اسم ال 
        public List<Employee> Manager  { get; set; } // Navigational property ==> FK بتحت ناحيه ال  (Navigational property) المكان اللي بيكون فيه ال
    }
}
