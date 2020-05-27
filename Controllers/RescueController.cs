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
    public class RescueController : Controller
    {
        private readonly ILogger<RescueController> _logger;

        public RescueController(ILogger<RescueController> logger)
        {
            _logger = logger;
        }

        public IActionResult Contacts() => View();
        public IActionResult Info() => View();
        public IActionResult News() => View();
        public IActionResult Donate() => View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
