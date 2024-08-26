using Assignment_Task02_EF_Core.Contexts;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Task02_EF_Core.Migrations
{
    [DbContext(typeof(ITIDbContext))]
    partial class ITIDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Course", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Description")
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.Property<TimeSpan>("Duration")
                    .HasColumnType("time");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<int>("TopicId")
                    .HasColumnType("int");

                b.HasKey("Id");

                b.HasIndex("TopicId");

                b.ToTable("Courses", "dbo");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Course_Inst", b =>
            {
                b.Property<int>("InstructorId")
                    .HasColumnType("int");

                b.Property<int>("CourseId")
                    .HasColumnType("int");

                b.Property<string>("Evaluate")
                    .IsRequired()
                    .HasMaxLength(500)
                    .HasColumnType("nvarchar(500)");

                b.HasKey("InstructorId", "CourseId");

                b.ToTable("Courses_Inst", "dbo");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Department", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<DateTime>("HireDate")
                    .HasColumnType("datetime2");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.HasKey("Id");

                b.ToTable("Departments", "dbo");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Instructor", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Address")
                    .IsRequired()
                    .HasMaxLength(200)
                    .HasColumnType("nvarchar(200)");

                b.Property<int>("Bonus")
                    .HasColumnType("int");

                b.Property<int>("DepartmentId")
                    .HasColumnType("int");

                b.Property<double>("HourlyRate")
                    .HasColumnType("float");

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<double>("Salary")
                    .HasColumnType("float");

                b.HasKey("Id");

                b.HasIndex("DepartmentId");

                b.ToTable("Instructors", "dbo");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Stud_Course", b =>
            {
                b.Property<int>("StudentId")
                    .HasColumnType("int");

                b.Property<int>("CourseId")
                    .HasColumnType("int");

                b.Property<string>("Grade")
                    .IsRequired()
                    .HasMaxLength(2)
                    .HasColumnType("nvarchar(2)");

                b.HasKey("StudentId", "CourseId");

                b.ToTable("Stud_Courses", "dbo");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Student", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Address")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.Property<int>("Age")
                    .HasColumnType("int");

                b.Property<int>("DepartmentId")
                    .HasColumnType("int");

                b.Property<string>("FirstName")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("nvarchar(50)");

                b.Property<string>("LastName")
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnType("varchar(50)");

                b.HasKey("Id");

                b.HasIndex("DepartmentId");

                b.ToTable("Students", "dbo");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Topic", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("int");

                SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                b.Property<string>("Name")
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnType("nvarchar(100)");

                b.HasKey("Id");

                b.ToTable("Topics", "dbo");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Course", b =>
            {
                b.HasOne("Assignment_Task02_EF_Core..Entities.Topic", "Topic")
                    .WithMany("Courses")
                    .HasForeignKey("TopicId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Topic");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Instructor", b =>
            {
                b.HasOne("Assignment_Task02_EF_Core.Entities.Department", "Department")
                    .WithMany("Instructors")
                    .HasForeignKey("DepartmentId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Department");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Student", b =>
            {
                b.HasOne("CAssignment_Task02_EF_Core.Entities.Department", "Department")
                    .WithMany("Students")
                    .HasForeignKey("DepartmentId")
                    .OnDelete(DeleteBehavior.Cascade)
                    .IsRequired();

                b.Navigation("Department");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Department", b =>
            {
                b.Navigation("Instructors");

                b.Navigation("Students");
            });

            modelBuilder.Entity("Assignment_Task02_EF_Core.Entities.Topic", b =>
            {
                b.Navigation("Courses");
            });
#pragma warning restore 612, 618
        }
    }
}
