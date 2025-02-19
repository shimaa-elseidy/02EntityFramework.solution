using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using demo.Entity;
using Microsoft.EntityFrameworkCore;

namespace demo.Configurations
{
    internal class DepartmentConfiguraton : IEntityTypeConfiguration<Department>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Department> builder)
        {
            //builder.HasKey(nameof(Employee.Id));
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id).UseIdentityColumn(100, 100);
            builder.Property(e => e.DeptName).HasColumnType("varchar")
                                             .HasMaxLength(100);
            builder.Property(e => e.Description);
        }
    }
}
