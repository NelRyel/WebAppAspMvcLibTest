using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.CRUDs.CdudCompanies;
using WebAppAspMvcLibTest.entModels.Companies;
using WebAppAspMvcLibTest.entModels.Products;


namespace WebAppAspMvcLibTest.Controllers
{
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index(int NamecompTypeSelectIndex = 1, string name = "")
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
            
            //int selectedIndex = 1;

            //List<string> compTypesList = new List<string>() { "Company", "Developer", "Distributer", "Production", "Publisher", "Studio" };
            //SelectList types = new SelectList(compTypesList, "Id", "Name", selectedIndex);
            //ViewBag.Types = types;
            using (_DbContext db = new _DbContext())
            {
                //var a = db.Companies.ToList();
                //return View(a.OfType<Developer>());
                var a = db.Companies.ToList();
                switch (NamecompTypeSelectIndex)
                {
                    case 1:
                        return View(a);
                        break;
                    case 2:
                        return View(a.OfType<Developer>());
                        break;
                    case 3:
                        return View(a.OfType<Distributer>());
                        break;
                    case 4:
                        return View(a.OfType<Production>());
                        break;
                    case 5:
                        return View(a.OfType<Publisher>());
                        break;
                    case 6:
                        return View(a.OfType<Studio_Movie_Series_Animated>());
                        break;
                    default: return View("NOTHING HERE");
                }

               // return View(db.Companies.ToList());
            }

            //return View();
        }
        //public IActionResult GetItems(int id)
        //{
        //    using (_DbContext db = new _DbContext())
        //    {
        //        var a = db.Companies.ToList();
        //        switch (id)
        //        {
        //            case 1: return PartialView(a);
        //                break;
        //            case 2: return PartialView(a.OfType<Developer>());
        //                break;
        //            case 3: return PartialView(a.OfType<Distributer>());
        //                break;
        //            case 4: return PartialView(a.OfType<Production>());
        //                break;
        //            case 5: return PartialView(a.OfType<Publisher>());
        //                break;
        //            case 6: return PartialView(a.OfType<Studio_Movie_Series_Animated>());
        //                break;
        //            default: return PartialView("NOTHING HERE");
        //        }
                
        //        //return PartialView(a.oftype<developer>());
        //        //return view(db.companies.tolist());
        //    }
        //    //return PartialView();
        //}

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
