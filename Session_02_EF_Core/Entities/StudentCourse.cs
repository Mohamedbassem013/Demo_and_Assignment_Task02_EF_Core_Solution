using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session_02_EF_Core.Entities
{
    internal class StudentCourse
    {
        public int StudentId { get; set; }
        [Key]
        public int CourseId { get; set; }
        //public List<Course> courses { get; set; }
        //public List<Student> students { get; set; }
        public double Grade { get; set; }
    }
}
