using Day_3_Entity_Framework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;

namespace Day_3_Entity_Framework.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        public IActionResult Index()
        {
            ViewData["str1"] = "This is a string passed using ViewData";
            ViewData["num1"] = 100;

            ViewBag.str2 = "This is a string passed using ViewBag";
            ViewBag.num2 = 200;
            return View();
        }

        public ActionResult HtmlHelpers()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }

        public HomeController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }

        public ActionResult AddUser()
        {
            return View();
        }

        public ActionResult SaveUser(User u)
        {
            // These 3 lines are added afterwards
            string contentRoot = _webHostEnvironment.ContentRootPath;
            string path = Path.Combine(contentRoot, @"C:\Users\ANUBHASR\source\repos\Day_3_Entity_Framework\users.txt");
            StreamWriter sw = new StreamWriter(path, true);


            sw.WriteLine("User details added on: " + DateTime.Now.ToString());
            sw.WriteLine("User name: " + u.UserName);
            sw.WriteLine("Password: " + u.Password);
            sw.WriteLine();
            sw.Close();
            return Content("User details have been saved");
        }






        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
