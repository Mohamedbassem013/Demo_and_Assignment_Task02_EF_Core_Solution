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
    internal class CourseInstConfig : IEntityTypeConfiguration<Course_Inst>
    {
        public void Configure(EntityTypeBuilder<Course_Inst> builder)
        {
            builder.ToTable("Courses_Inst", "dbo");

            builder.HasKey(ci => new { ci.InstructorId, ci.CourseId });

            builder.Property(ci => ci.Evaluate)
                   .HasMaxLength(500);
        }
    }
}
