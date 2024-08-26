using Assignment_Task02_EF_Core.Configrations;
using Assignment_Task02_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task02_EF_Core.Contexts
{
    internal class ITIDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=ITI_DB2;Trusted_Connection=True;Encrypt=False");
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Course_Inst> Courses_Inst { get; set; }
        public DbSet<Stud_Course> Stud_Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Course>(new CourseConfig());
            modelBuilder.ApplyConfiguration<Instructor>(new InstructorConfig());
            modelBuilder.ApplyConfiguration<Topic>(new TopicConfig());
            modelBuilder.ApplyConfiguration<Student>(new StudentConfig());
            modelBuilder.ApplyConfiguration<Department>(new DepartmentConfig());
            modelBuilder.ApplyConfiguration<Course_Inst>(new CourseInstConfig());
            modelBuilder.ApplyConfiguration<Stud_Course>(new StudCourseConfig());


        }
    }
}
