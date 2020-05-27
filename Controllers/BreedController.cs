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
    public class BreedController : Controller
    {
        private readonly ILogger<BreedController> _logger;

        public BreedController(ILogger<BreedController> logger)
        {
            _logger = logger;
        }

        public IActionResult History() => View();
        public IActionResult Choosing() => View();


        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
