using System;
using System.Collections.Generic;

namespace Lab2___Core.Models
{
    public partial class Instructor
    {
        public Instructor()
        {
            Departments = new HashSet<Department>();
            InsCourses = new HashSet<InsCourse>();
        }

        public int InsId { get; set; }
        public string? InsName { get; set; }
        public string? InsDegree { get; set; }
        public decimal? Salary { get; set; }
        public int? DeptId { get; set; }

        public virtual Department? Dept { get; set; }
        public virtual ICollection<Department> Departments { get; set; }
        public virtual ICollection<InsCourse> InsCourses { get; set; }
    }
}
