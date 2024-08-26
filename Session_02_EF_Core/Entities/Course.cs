using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session_02_EF_Core.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> students { get; set; }
        public List<Student> students { get; set; }
    }
}
