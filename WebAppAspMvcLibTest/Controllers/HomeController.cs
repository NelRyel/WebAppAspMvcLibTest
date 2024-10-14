using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Products;
using WebAppAspMvcLibTest.Models;

namespace WebAppAspMvcLibTest.Controllers
{
    public class HomeController : Controller
    {

        //_DbContext db;
        //public HomeController(_DbContext context)
        //{
        //    db = context;
        //}

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
            using (_DbContext db = new _DbContext())
            {
                Game g = new Game();
                g.Name = "Nier: Automata";
                db.Games.Add(g);
                db.SaveChanges();

            }

        }

        public IActionResult Index()
        {
            using(_DbContext db = new _DbContext())
            {
                return View(db.Games.ToList());
            }
            //return View();
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
