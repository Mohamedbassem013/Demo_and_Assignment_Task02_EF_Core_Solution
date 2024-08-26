using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task02_EF_Core.Entities
{
    [Table("Instructors", Schema = "dbo")]
    internal class Instructor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string Address { get; set; }

        public int Bonus { get; set; }

        [Required]
        public double Salary { get; set; }

        [Required]
        public double HourlyRate { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey("DepartmentId")]
        public Department Department { get; set; }  // Navigation property to Department
    }
}
