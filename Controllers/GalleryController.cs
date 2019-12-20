using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineApplication.Data;
using OnlineApplication.Models;

namespace OnlineApplication.Controllers
{
    public class GalleryController : Controller
    {
        private IWebHostEnvironment _host;
        private ApplicationDbContext _context;

        public GalleryController(IWebHostEnvironment host,ApplicationDbContext context)
        {
            _host = host;
            _context = context;
        }
        public IActionResult Index()
        {
            var profiles = _context.Profiles.ToList();
            return View(profiles);
        }
        [HttpGet]
        public IActionResult AddProfile()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddProfile(Profile profile ,IFormFile image)
        {
            if (ModelState.IsValid)
            {
                string filename = Guid.NewGuid().ToString() + image.FileName;
                string rootpath = _host.WebRootPath+"/Gallery";
                var filepath = Path.Combine(rootpath,filename);

                var fs = new FileStream(filepath, FileMode.OpenOrCreate);
                image.CopyToAsync(fs);
                profile.ProfilePicture ="/Gallery/"+filename;
                _context.Profiles.Add(profile);
                _context.SaveChanges();
                return Redirect("/gallery");

            }
            return View();
        }
    }
}