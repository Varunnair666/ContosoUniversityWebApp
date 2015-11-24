using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ContosoUniversityWebApp.Models
{
    public class Department
    {
        public int ID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDesc { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}