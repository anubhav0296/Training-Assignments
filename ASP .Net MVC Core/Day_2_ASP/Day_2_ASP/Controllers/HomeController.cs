using Day_2_ASP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Day_2_ASP.Controllers
{
    //[Route("Home")]
    //[Route("[controller]")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //[Route("")]
        //[Route("~/")]
        //[RouteAttribute("Home")]
        //[RouteAttribute("Home/Index")]
        //[Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        //[Route("Home/Privacy/{Id?}")]
        //public int Privacy(int? id)
        //{
        //    return id??1;
        //    //return View();
        //}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
