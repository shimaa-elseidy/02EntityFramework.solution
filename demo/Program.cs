using System;
using demo.Contexts;
using demo.Entity;
using Microsoft.EntityFrameworkCore;

namespace demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Rev..
            // EF Core :: ORM in .Net [Object Relational Mapper] --> link between Database & Application
            // link between Database & Application --> [ ADO , ORM , Dapper ]
            // ORM :: 
            // 1. Mapping :: Code First [generate table per class] Or Database First [generate class per table]
            // 2. L2E     :: [ C# Code (LINQ) To  --> SQL Database ]
            // EF Core --> translate C# to SQL  (database does't understand C# , Sql only)
            // 3 Ways to generate schema if there is inheritance
            // TPC || TPH || TPCC 
            // TPC :: Table Per Class
            // TPH :: Table Per Hierarchy
            // TPCC:: Table Per Concret Class
            #endregion
            #region Prepere for CRUD operations
            // CRUD :: Create - Read - Update - Delete
            // AppDpContext context = new AppDpContext();
            //try
            //{
            //    // code
            //}
            //finally
            //{
            //     context.Dispose(); // To close connection with database
            //}

            //using (AppDpContext context = new AppDpContext())    // Syntax Sugar
            //{
            //    // CRUD code
            //}

            // using AppDpContext context = new AppDpContext();    // Syntax Sugar
            #endregion
            using AppDpContext appDpContext = new AppDpContext();
            #region CRUD operation (Create - Insert)
            // Create - Insert
            //var employee = new Employee() { Name ="shimaa elseidy" , Salary=1200000 , Address = "Cairo" , Age = 25};
            //Console.WriteLine(appDpContext.Entry(employee).State); // Detached 
            //appDpContext.Add(employee);
            //appDpContext.employees.Add(employee);
            //Console.WriteLine(appDpContext.Entry(employee).State); // Added 
            //appDpContext.SaveChanges();
            //Console.WriteLine(appDpContext.Entry(employee).State); // Unchanged
            //appDpContext.employees.Add(employee);
            //appDpContext.SaveChanges();
            //appDpContext.Entry(employee).State=EntityState.Added;
            //appDpContext.SaveChanges();
            #endregion
        }
    }

}
