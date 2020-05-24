using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using demo_mvc.Models;

namespace demo_mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly TestService service;
        private readonly ILogger<HomeController> logger;
        public HomeController(TestService service, ILogger<HomeController> logger)
        {
            this.logger = logger;
            this.service = service;

        }

        public IActionResult Index()
        {
            service.Test();
            return View();
        }

        public IActionResult Miss()
        {
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
