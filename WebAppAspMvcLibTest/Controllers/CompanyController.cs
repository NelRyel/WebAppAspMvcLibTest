using Microsoft.AspNetCore.Mvc;
using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

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

        public IActionResult AddViewCompany()
        {
            return View();
        }

        public async Task<IActionResult> CreateCompany(Company company)
        {
            using (var db = new _DbContext()) {
                db.Companies.Add(company);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            
            }
        }
    }
}
