using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Collections;
using webappsql.Models;
using webappsql.Services;

namespace webappsql.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseService _courseService;
        private readonly IConfiguration _configuation;

        public CourseController(ICourseService courseService, IConfiguration configuation)
        {
            _courseService = courseService;
            _configuation = configuation;
        }
        public IActionResult Index()
        {
            var _list = _courseService.GetCourses(_configuation.GetConnectionString("appdb"));
            return View(_list);
        }
    }
}
