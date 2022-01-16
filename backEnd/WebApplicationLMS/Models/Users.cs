using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LMSCourses.Models
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Avatar { get; set; }

        //[DataType(DataType.EmailAddress)]
        //public object UsersEmail { get; set; }

        public string Department { get; set; }
        public string Manager{ get; set; }
        public Roles RoleId { get; set; }

    }
}
