using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OnlineApplication.Data;
using OnlineApplication.Models;

namespace OnlineApplication.Controllers
{
    public class ApplicationController : Controller
    {
        private ApplicationDbContext _context;

        public ApplicationController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Application> apps = _context.Applications.ToList();
            return View(apps);
        }
        [HttpGet]
        public IActionResult AddApplication()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddApplication(Application app)
        {
            if (ModelState.IsValid)
            {
                _context.Applications.Add(app);
                _context.SaveChanges();
            }
            return View("ApplicationDetail",app);
        }
        
        public IActionResult ApplicationDetail(int id)
        {
            Application app = _context.Applications.Find(id);
            return View(app);
        }
    }
}