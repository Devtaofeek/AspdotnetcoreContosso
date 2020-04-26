using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspdotnetcoreContosso.Models
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)] // this attribute lets you enter the value for the primary key manually rather than having the databse generate it
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
