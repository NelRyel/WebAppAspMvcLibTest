using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class devdev: _CrudCompany
    {
        public override void CreateCompany(string name)
        {
            using (_DbContext db = new _DbContext())
            {
                Developer developer = new Developer();
                developer.Name = name;
                db.Developers.Add(developer);
                db.SaveChanges();
            }
        }
    }
}
