using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment_Task02_EF_Core.Entities;

namespace Assignment_Task02_EF_Core.Configrations
{
    internal class StudCourseConfig : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> builder)
        {
            builder.ToTable("Stud_Courses", "dbo");
            builder.HasKey(sc => new { sc.StudentId, sc.CourseId });
            builder.Property(sc => sc.Grade)
                   .HasMaxLength(2);
        }
    }
}
