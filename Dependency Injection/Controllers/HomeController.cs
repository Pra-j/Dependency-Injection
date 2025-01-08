using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Dependency_Injection.Models;
using Dependency_Injection.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Dependency_Injection.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHomeService _homeService;
        private readonly ITestService _testService;
        private readonly INameService _nameService;
        private readonly IAgeService _ageService;
        private readonly IRollService _rollService;

        public HomeController(ILogger<HomeController> logger, IHomeService homeService, ITestService testService, INameService nameService, IRollService rollService, IAgeService ageService)
        {
            _logger = logger;
            _homeService = homeService;
            _testService = testService;
            _nameService = nameService;
            _rollService = rollService;
            _ageService = ageService;
        }

      

        public IActionResult Index()
        {
            ViewBag.TestMessage = _testService.GetMessage();
            ViewBag.HomeMessage = _homeService.GetMessage();
            ViewBag.Name = _nameService.GetName();
            ViewBag.Age = _ageService.GetAge();
            ViewBag.RollNumber = _rollService.GetRoll();

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
