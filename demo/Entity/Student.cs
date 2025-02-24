using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.Entity
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int  Age { get; set; }
        List<StudentCourse> courses { get; set; }
    }
}
