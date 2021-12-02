using System;
using System.Collections.Generic;

namespace Lab2___Core.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Courses = new HashSet<Course>();
        }

        public int TopId { get; set; }
        public string? TopName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
