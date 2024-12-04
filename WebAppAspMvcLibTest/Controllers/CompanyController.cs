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

<<<<<<< HEAD
        public IActionResult AddViewCompany()
=======
        public IActionResult AddCompany()
>>>>>>> 40bd2797b26956c744125358a9a7735add3a7053
        {
            return View();
        }

<<<<<<< HEAD
        public async Task<IActionResult> CreateCompany(Company company)
        {
            using (var db = new _DbContext()) {
                db.Companies.Add(company);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            
            }
        }
=======
        public 
>>>>>>> 40bd2797b26956c744125358a9a7735add3a7053
    }
}
