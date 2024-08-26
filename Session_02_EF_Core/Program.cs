using Demo_Session_02_EF_Core.Context;
using Demo_Session_02_EF_Core.Entities;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        #region Revision
        // EF Core : OPM in .NET
        // OPM

        // 1. Mapping
        // Code First [ Generate Table Per Classes]
        // DB First   [ Generate Class Per Classes]

        // 2. L2E [C# Code (LINQ) --> EF Core --> SQL DB]

        // 3. Ways Generate 
        // 1. TPC : Table Per Class
        // 2. TPH : Table Per Hierarichy
        // 3. TPCC : Table Per Concret Class 
        #endregion

        #region CURD Operation

        // CURD Operation
        // Create - Read - Update - Delete
        //AppDbContext context = new AppDbContext();
        //try
        //{
        //    //code
        //}
        //finally 
        //{

        //    context.Dispose();
        //}

        //using(AppDbContext context = new AppDbContext())
        //{
        //    // CURD
        //}

        //
        //using AppDbContext context = new AppDbContext();

        #endregion

        #region Create - Insert 

        // Create - Insert

        //var employee = new Employee()
        //{
        //    Name = "Ahmed Ali",
        //    Salary = 12000,
        //    Address = "Cairo",
        //    Age = 25
        //};

        //Console.WriteLine(context.Entry(employee).State);//Detached
        ////context.Add(employee);
        // context.employees.Add(employee);

        // Console.WriteLine(context.Entry(employee).State);//Added
        //var result =context.SaveChanges();

        //Console.WriteLine(context.Entry(employee).State);//UnChanged

        //employee.Name = "Omar";

        //Console.WriteLine(context.Entry(employee).State);// Modified


        //Console.WriteLine(result);

        //Console.WriteLine(context.Entry(employee).State);

        //context.Entry(employee).State = EntityState.Added;

        //Console.WriteLine(context.Entry(employee).State);

        //context.SaveChanges();

        #endregion

        #region Read - Select
        // Read - Select

        //var result = context.employees.Where(E => E.Id == 40).FirstOrDefault();
        //var result = context.employees.FirstOrDefault(E => E.Id == 40);


        //var result = context.employees.Select(E => E.Name);

        //Console.WriteLine(context.Entry(result).State);//UnChanged

        //result.Name = "Ali";
        //Console.WriteLine(context.Entry(result).State);//Modified

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        //Console.WriteLine(result?.Name);
        //Console.WriteLine(result?.Id); 
        #endregion

        #region Update
        // Update

        //var result = context.employees.FirstOrDefault(E => E.Id == 40);

        // Console.WriteLine(context.Entry(result).State);

        // result.Name = "Omar Mohamed";

        // //Console.WriteLine(context.Entry(result).State);
        // context.Update(result);

        // Console.WriteLine(context.Entry(result).State);

        // context.SaveChanges();

        // Console.WriteLine(context.Entry(result).State); 
        #endregion

        #region Delete
        //// Delete

        //var result = context.employees.FirstOrDefault(E => E.Id == 30);

        //Console.WriteLine(context.Entry(result).State); //UnChanged

        //context.employees.Remove(result);

        //Console.WriteLine(context.Entry(result).State);//Delete

        //context.SaveChanges();

        //Console.WriteLine(context.Entry(result).State);// Detached 
        #endregion

    }
}