using Microsoft.AspNetCore.Mvc;
using WebAppAspMvcLibTest.ContextModel;


namespace WebAppAspMvcLibTest.Controllers
{
    public class CompanyController : Controller
    {
        public IActionResult Index()
        {
            using (_DbContext db = new _DbContext())
            {
                return View(db.Companies.ToList());
            }

            //return View();
        }

        public IActionResult AddCompany()
        {
            return View();
        }

        public 
    }
}
