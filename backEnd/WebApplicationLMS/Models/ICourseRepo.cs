using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCourses.Models
{
    public interface ICourseRepo
    {
        IEnumerable<Courses> AllCourses { get; }
        Courses GetCourseById(int courseId);
    }
}
