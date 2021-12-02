using System;
using System.Collections.Generic;

namespace Lab2___Core.Models
{
    public partial class Course
    {
        public Course()
        {
            InsCourses = new HashSet<InsCourse>();
            StudCourses = new HashSet<StudCourse>();
        }

        public int CrsId { get; set; }
        public string? CrsName { get; set; }
        public int? CrsDuration { get; set; }
        public int? TopId { get; set; }

        public virtual Topic? Top { get; set; }
        public virtual ICollection<InsCourse> InsCourses { get; set; }
        public virtual ICollection<StudCourse> StudCourses { get; set; }
    }
}
