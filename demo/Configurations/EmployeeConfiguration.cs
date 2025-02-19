using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace demo.Configurations
{
    internal class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn(10,10);
            builder.Property(e => e.Name).HasColumnName("EmployeeName")
                                         .HasColumnType("varchar")
                                         .HasMaxLength(50)
                                         .IsRequired();
            builder.Property(e => e.Age);
            builder.Property(e => e.Salary).HasColumnType("decimal(18,3)").IsRequired(false);
            builder.Property(e => e.Address);

        }
    }
}