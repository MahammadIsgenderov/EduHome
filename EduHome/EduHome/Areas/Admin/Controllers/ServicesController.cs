using EduHome.DAL;
using EduHome.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EduHome.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private readonly AppDbContext _db;
        public ServicesController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            List<Service> services = _db.services.OrderByDescending(x=>x.Id).ToList();
            return View(services);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Name,string Description)
        {
            Service service = new Service()
            {
                Name = Name,
                Description = Description
            };
            _db.services.Add(service);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
