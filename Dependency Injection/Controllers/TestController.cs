using Dependency_Injection.Services;
using Microsoft.AspNetCore.Mvc;

namespace Dependency_Injection.Controllers
{
    public class TestController : Controller
    {
        private readonly ITestService _testService;

        public TestController( ITestService testService)
        {
            _testService = testService;
        }

        public IActionResult Index()
        {
            var a = _testService.GetMessage();
            return Ok(a);
        }
    }
}
