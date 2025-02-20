using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using demo.Configurations;
using demo.Entity;
using Microsoft.EntityFrameworkCore;


namespace demo.Contexts
{
    internal class AppDpContext : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguraton());
            // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            modelBuilder.Entity<Employee>().HasOne(e => e.Department).WithOne(d => d.Maneger).HasForeignKey<Department>(d=>d.EmpId);
            modelBuilder.Entity<Department>().HasMany(d => d.Employees).WithOne(e => e.WorkFor).HasForeignKey(d=>d.WorkForId);
            base.OnModelCreating(modelBuilder);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // connect to database
            optionsBuilder.UseSqlServer("Server = Shimaa123 ; Database = AppDb01 ; Trusted_Connection = True ; TrustServerCertificate = True");
        }
    }
}
