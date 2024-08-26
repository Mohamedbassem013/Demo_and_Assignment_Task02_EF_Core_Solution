using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task02_EF_Core.Entities
{
    [Table("Departments", Schema = "dbo")]
    internal class Department
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        public ICollection<Instructor> Instructors { get; set; } = new List<Instructor>();

        public ICollection<Student> Students { get; set; } = new List<Student>();
    }
}
