using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCourses.Models
{
    public class CourseEnrollments
    {
        public int Id { get; set; }
        public Courses CourseId { get; set; }
        public Users UserId { get; set; }
    }
}
