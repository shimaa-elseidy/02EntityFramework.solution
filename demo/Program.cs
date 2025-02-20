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
            #region CRUD Operations (Retreive)
            // CRUD :: read - select
            //var output = appDpContext.employees.FirstOrDefault();
            ////Console.WriteLine(output ?? null  );
            //Console.WriteLine(appDpContext.Entry(output).State); // Unchanged
            //output.Name = "omar";
            //appDpContext.SaveChanges();
            //Console.WriteLine(appDpContext.Entry(output).State); // Modified
            #endregion
            #region CRUD Operations (Update)
            //var output = appDpContext.employees.FirstOrDefault(x => x.Id == 80 );
            ////Console.WriteLine(appDpContext.Entry(output).State); // Unchanged
            //output.Name = "meshmesha";
            ////Console.WriteLine(appDpContext.Entry(output).State); // Modified
            ////appDpContext.Update(output);
            //appDpContext.SaveChanges(); 
            #endregion
            #region CRUD Operations (Delete)
            //var output = appDpContext.employees.FirstOrDefault(e => e.Id == 80);
            //appDpContext.employees.Remove(output);
            //appDpContext.SaveChanges();
            #endregion
            #region One To One Relationship
            //Department department = new Department();
            #endregion
          
        }
    }

}
