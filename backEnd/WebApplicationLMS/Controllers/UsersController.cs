using LMSCourses.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationLMS.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : Controller
    {
        private readonly IUserRepo _usersRepo;

        private readonly ILogger<UsersController> _logger;

        public UsersController(IUserRepo usersRepo)
        {
            _usersRepo = usersRepo;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_usersRepo.AllUsers);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(_usersRepo.GetUserById(id));
        }
        }
    }
