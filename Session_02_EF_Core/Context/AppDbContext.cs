using Demo_Session_02_EF_Core.Configurations;
using Demo_Session_02_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Session_02_EF_Core.Context
{
    internal class AppDbContext : DbContext
    {
        public AppDbContext():base()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //// Id
            //modelBuilder.Entity<Employee>().HasKey(E => E.EmpId); // هنا خليت ال EmpId --> PK
            //modelBuilder.Entity<Employee>()
            //            //.Property(E => E.EmpId)
            //            //.Property("EmpId")
            //            .Property(nameof(Employee.EmpId)) // التلت طرق دول صح 
            //            .UseIdentityColumn(1,1); // طب هنا عاوز عاوز احط constains علي Column ال EmpId
            //// Name
            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Name)
            //            .HasColumnType("Varchar")
            //            .HasMaxLength(50)
            //            .HasDefaultValue("Ahmed");

            //// Salary
            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Salary)
            //            .HasColumnType("money");

            //---------------------------------------------------------------------------------------
            // في override تاني بدل ما اعمل كب الكلام ده لوحده اعمله ف مكان واحد كدا
            //modelBuilder.Entity<Employee>(E =>
            //{
            //    // Id
            //    E.HasKey(E => E.EmpId); // هنا خليت ال EmpId --> PK
            //    E//.Property(E => E.EmpId)
            //     //.Property("EmpId")
            //     .Property(nameof(Employee.EmpId)) // التلت طرق دول صح 
            //     .UseIdentityColumn(1, 1); // طب هنا عاوز عاوز احط constains علي Column ال EmpId
            //                                          // Name
            //    E.Property(E => E.Name)
            //     .HasColumnType("Varchar")
            //     .HasMaxLength(50)
            //     .HasDefaultValue("Ahmed");

            //    // Salary
            //    E.Property(E => E.Salary)
            //     .HasColumnType("money");

            //});


            #region Fluent API
            //modelBuilder.Entity<Employee>()
            //            .HasOne(E => E.departments )
            //            .WithOne(D => D.Manager)
            //            .HasForeignKey<Department>(D => D.Id);

            //modelBuilder.Entity<Department>()
            //          .HasMany(D => D.Employee)
            //          .WithOne(E => E.WorkFor)
            //          .HasForeignKey(E => E.WorkForId);


            //modelBuilder.Entity<Employee>().HasKey("Id");
            //modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //modelBuilder.Entity<Employee>().HasKey(nameof(Employee.Id));


            //modelBuilder.Entity<Employee>().HasKey(E => E.Id);
            //modelBuilder.Entity<Employee>()
            //            .Property(E => E.Id)
            //            .UseIdentityColumn(10, 10)
            //            .HasColumnName("EmployeeName")
            //            .HasColumnType("nvarchar")
            //            .HasMaxLength(50)
            //            .IsRequired();

            //modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            #endregion

           // modelBuilder.Entity<StudentCourse>().HasKey(SC => new { SC.CourseId , SC.StudentId});
           // modelBuilder.Entity<StudentCourse>().HasNoKey();


            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // مسؤاله انها تفتح connection
        {
            optionsBuilder.UseSqlServer("Server = DESKTOP-DA9SS6B\\MSSQLSERVER04; Database = Company; Trusted_Connection = True ; ");
        }
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Student> students { get; set; }
        public DbSet<Course> courses { get; set; }
    }
}
