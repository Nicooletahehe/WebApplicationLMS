using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCourses.Models
{
    public class CoursesRepo : ICourseRepo
    {
        private readonly AppDbContext _appDbContext;
        public CoursesRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Courses> AllCourses
        {
            get
            {
                //return _appDbContext.Users.Include(c =>c.Roles);
                return _appDbContext.Courses;
            }
        }

        public Courses GetCourseById(int courseId)
        {
            return _appDbContext.Courses.FirstOrDefault(p => p.Id == courseId);
        }
    }
}
