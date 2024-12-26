using Microsoft.AspNetCore.Mvc;
using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.CRUDs.CdudCompanies;
using WebAppAspMvcLibTest.entModels.Companies;


namespace WebAppAspMvcLibTest.Controllers
{
    public class CompanyController : Controller
    {

        public IActionResult Index(int NamecompTypeSelectIndex)
        {
            #region // тесты тесты
            //using (_DbContext db = new _DbContext())
            //{
            //    Company company = db.Companies.Find(2);
            //    //company.Name = "changedNameFromComp";
            //    //db.SaveChanges();
            //    company.Name = "newNameTestDb111";
            //    Console.WriteLine("+++++++++++++");
            //    Console.WriteLine(company.Name);
            //    Console.WriteLine("+++++++++++++");
            //    db.SaveChanges();

            //}
            //_CrudDeveloper cd = new _CrudDeveloper();
            //cd.UpdateCompany("UpdatecrudTestDevComp", 9);
            #endregion
            Console.WriteLine("+++++++++++++");
            Console.WriteLine(NamecompTypeSelectIndex.ToString());
            Console.WriteLine("+++++++++++++");
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
                    d.CreateCompany(company.Name);
                    break;
                case 3: _CrudDistributer dis = new _CrudDistributer();
                    dis.CreateCompany(company.Name);
                    break;
                case 4: _CrudProduction prod = new _CrudProduction();
                    prod.CreateCompany(company.Name);
                    break;
                case 5: _CrudPublisher pub = new _CrudPublisher();
                    pub.CreateCompany(company.Name);
                    break;
                case 6:_CrudStudio_Movie_Series_Animated st = new _CrudStudio_Movie_Series_Animated();
                    st.CreateCompany(company.Name);
                    break;
                default:
                    Console.WriteLine( "WRONG CHOSE IN CREATE COMPANY");
                    break;

            }
            return RedirectToAction("Index");
           
        }
    }
}
