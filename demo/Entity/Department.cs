using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Entity
{
    internal class Department
    {
        public int Id { get; set; }
        public string DeptName { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(Department.Maneger))]
        public int EmpId    { get; set; }
       public Employee Maneger { get; set; } // navigational property
        
    }
}
