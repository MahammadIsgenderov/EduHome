using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace EduHome.Controllers
{
    public class CourseController : Controller
    {
        private readonly AppDbContext _db;
        public CourseController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Courses> courses = _db.courses.OrderByDescending(x=> x.Id).Take(6).ToList();
            return View(courses);
        }
        public IActionResult LoadMore()
        {
            List<Courses> courses = _db.courses.OrderByDescending(x => x.Id).Skip(6).Take(6).ToList();
            return PartialView("_LoadMoreCoursesPartial",courses);
        }
    }
}
