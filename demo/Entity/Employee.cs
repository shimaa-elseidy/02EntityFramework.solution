using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Entity
{
    // Model / Entity
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double? Salary { get; set; }
        public string Address { get; set; }
        [InverseProperty(nameof(Department.Maneger))]
        public Department? Department { get; set; } // navigational property
       
    }
}
