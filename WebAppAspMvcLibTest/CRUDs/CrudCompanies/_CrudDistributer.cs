using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class _CrudDistributer: _CrudCompany
    {
        public override void CreateCompany(string name)
        {
            using (_DbContext db = new _DbContext())
            {
                Distributer c = new Distributer();
                c.Name = name;
                db.Distributers.Add(c);
                db.SaveChanges();
            }
        }
       

    }
}
