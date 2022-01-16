using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using LMSCourses.Models;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Extensions.Logging;

namespace LMSCourses.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoursesController : Controller
    {
        private readonly ICourseRepo _coursesRepo;

        private readonly ILogger<CoursesController> _logger;

        public CoursesController(ICourseRepo coursesRepo)
        {
            _coursesRepo = coursesRepo;
        }

        [HttpGet]
        public JsonResult Get()
        {
            return new JsonResult(_coursesRepo.AllCourses);
        }

        [HttpGet("{id}")]
        public JsonResult Get(int id)
        {
            return new JsonResult(_coursesRepo.GetCourseById(id));
        }
    }
}
