using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class _CrudProduction: _CrudCompany
    {
        public override void CreateCompany(string name)
        {
            using (_DbContext db = new _DbContext())
            {
                Production c = new Production();
                c.Name = name;
                db.Productions.Add(c);
                db.SaveChanges();
            }
        }
      
    }
}
