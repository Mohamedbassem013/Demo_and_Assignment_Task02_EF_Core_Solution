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
    internal class StudentConfig : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("Students", "dbo");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.FirstName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(t => t.LastName)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.Property(t => t.Address)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.Property(t => t.Age)
                   .IsRequired();


        }
    }
}
