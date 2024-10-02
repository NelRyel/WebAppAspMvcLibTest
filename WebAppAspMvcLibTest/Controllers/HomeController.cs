using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.Models;

namespace WebAppAspMvcLibTest.Controllers
{
    public class HomeController : Controller
    {

        _DbContext db;
        public HomeController(_DbContext context)
        {
            db = context;
        }

        //public HomeController()
        //{
        //    using(_DbContext context = new _DbContext())
        //    {

        //    }
        //}

        //public string Index()
        //{
        //    return "HELLO CONTROLLER";
        //}

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
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
