using EduHome.DAL;
using EduHome.Models;
using EduHome.ViewsModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHome.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }   

        public IActionResult Index()
        {
            List<Slider> sliders=_db.sliders.ToList();
            List<Service> services=_db.services.ToList();
            About abouts=_db.abouts.FirstOrDefault();
            //List<Courses> courses= _db.courses.OrderByDescending(x=> x.Id).Skip(1).Take(3).ToList();
            List<Courses> courses=_db.courses.OrderByDescending(course=>course.Id).ToList();
            List<NoticeBoard> noticeboards= _db.noticeboards.ToList();
            Info infos= _db.infos.First();
            List<Blog> blogs=_db.blogs.ToList();
            HomeVM homeVM = new HomeVM()
            {
                Sliders = sliders,
                Services = services,
                Abouts=abouts,
                Courses=courses,
                NoticeBoards=noticeboards,
                Info=infos,
                Blogs=blogs

            };
            return View(homeVM);
        }

        
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
