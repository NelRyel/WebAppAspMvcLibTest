using Microsoft.AspNetCore.Mvc;
using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.CRUDs.CdudCompanies;
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


        delegate void CompaniesDelegate();

        [HttpPost]
        public async Task<IActionResult> CreateCompany(Company company, int compTypeSelect)
        {
            // < option value = "1" > Company </ option >
            //< option value = "2" > Developer </ option >
            //< option value = "3" > Distrtibuter </ option >
            //< option value = "4" > Production </ option >
            //< option value = "5" > Publisher </ option >
            //< option value = "6" > Studio </ option >
            
            switch (compTypeSelect)
            {
                case 1: _CrudCompany c = new _CrudCompany();
                    c.CreateCompany(company.Name);
                    break;
                case 2: _CrudDeveloper d = new _CrudDeveloper();
                    d.CreateDeveloper(company.Name);
                    break;
                case 3: _CrudDistributer dis = new _CrudDistributer();
                    dis.CreateDistributer(company.Name);
                    break;
                case 4: _CrudProduction prod = new _CrudProduction();
                    prod.CreateProduction(company.Name);
                    break;
                case 5: _CrudPublisher pub = new _CrudPublisher();
                    pub.CreatePublisher(company.Name);
                    break;
                case 6:_CrudStudio_Movie_Series_Animated st = new _CrudStudio_Movie_Series_Animated();
                    st.CreateStudio_Movie_Series_Animated(company.Name);
                    break;
                default:
                    Console.WriteLine( "WROG CHOSE IN CREATE COMPANY");
                    break;

            }
            return RedirectToAction("Index");
            //Console.WriteLine("HELLO INT CREATE COMPANY");
            //Console.WriteLine( compTypeSelect.ToString() );
            //using (var db = new _DbContext()) {
            //   // db.Companies.Add(company);
            //    //await db.SaveChangesAsync();

            //    return RedirectToAction("Index");
            
            //}
        }
    }
}
