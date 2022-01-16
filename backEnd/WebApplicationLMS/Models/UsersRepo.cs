using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCourses.Models
{
    public class UsersRepo : IUserRepo
    {
        private readonly AppDbContext _appDbContext;
        public UsersRepo(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Users> AllUsers
        {
            get
            {
                var roleName = _appDbContext.Roles.Select(r => r.Role.Name);
                return _appDbContext.Users.Include(c => c.Role);
            }
        }

        public Users GetUserById(int userId)
        {
            return _appDbContext.Users.Include(c => c.Role).FirstOrDefault(p => p.Id == userId);
        }
    }
}
