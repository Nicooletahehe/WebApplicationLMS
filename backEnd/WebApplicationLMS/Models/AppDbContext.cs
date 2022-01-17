using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LMSCourses.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Courses> Courses { get; set; }
        
        public DbSet<Users> Users { get; set; }

        public DbSet<Users> Roles { get; set; }

        public DbSet<Users> CoursesEnrollments { get; set; }
    }
}
