using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task02_EF_Core.Entities
{
    [Table("Courses_Inst", Schema = "dbo")]
    internal class Course_Inst
    {
        [Required]
        //[ForeignKey("Instructores")]
        public int InstructorId { get; set; }

        [Required]
        //[ForeignKey("Courses")]
        public int CourseId { get; set; }

        public string Evaluate { get; set; }

    }
}
