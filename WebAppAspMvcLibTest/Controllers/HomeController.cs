using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.GenresModel;
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
            //MyDefaultInit defaultInit = new MyDefaultInit();
            //defaultInit.CreateGenres();
            //defaultInit.CreateMovieGenres();
            _logger = logger;
            using (_DbContext db = new _DbContext())
            {
                //Game game = new Game();
                //game.Name = "Nier: Automata";
                //game.ReleasYear = 2017;
                //db.Games.Add(game);

                //GameGenre gameGenre = new GameGenre();
                //gameGenre.Name = "Action";
                //db.GamesGenres.Add(gameGenre);

                //Game game = db.Games.Include(s => s.GameGenres).FirstOrDefault()!;
                // GameGenre gameGenre = db.GamesGenres.FirstOrDefault()!;

                // game.GameGenres.Add(gameGenre);

                //game.GameGenres.Add(gameGenre);



                //db.SaveChanges();

                //Console.WriteLine( game.Name + " " + gameGenre.Name  );


                //g.Genres.Add(gameGenre);
                //db.SaveChanges();

                // Console.WriteLine( db.Genres.FirstOrDefault().Name);
               

                Console.WriteLine(  "HELLO IN HOMECONTROLLER");
            }

        }

        public IActionResult Index()
        {
            using(_DbContext db = new _DbContext())
            {
                return View(db.Products.ToList());
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
