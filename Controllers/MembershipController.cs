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
    public class MembershipController : Controller
    {
        private readonly ILogger<MembershipController> _logger;

        public MembershipController(ILogger<MembershipController> logger)
        {
            _logger = logger;
        }

        public IActionResult Benefits() => View();
        public IActionResult NewMembers() => View();
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
