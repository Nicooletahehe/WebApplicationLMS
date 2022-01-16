using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCourses.Models
{
    public interface IUserRepo
    {
        IEnumerable<Users> AllUsers { get; }
        Users GetUserById(int courseId);
    }
}
