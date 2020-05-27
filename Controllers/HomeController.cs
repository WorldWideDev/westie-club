using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WestieClub.Models;

namespace WestieClub.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index() => View();
       
        public IActionResult Calendar() => View();
        public IActionResult Contacts() => View();
        public IActionResult Newsletter() => View();
        public IActionResult History() => View();
        public IActionResult Code() => View();
        public IActionResult MissionStatement() => View();
        public IActionResult Referral() => View();
        [HttpPost]
        public IActionResult Referral(Referral model)
        {
            if(ModelState.IsValid)
            {
                // create a new Referral, eventually
                return RedirectToAction("Index");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
