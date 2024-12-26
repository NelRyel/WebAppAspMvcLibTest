using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class _CrudCompany
    {
        public virtual void CreateCompany(string name)
        {
            using (_DbContext db = new _DbContext())
            {
                Company c = new Company();
                c.Name = name;
                db.Companies.Add(c);
                db.SaveChanges();
            }
        }
        public void UpdateCompany(string name, int id)
        {
            using (_DbContext db = new _DbContext())
            {
                Company c = db.Companies.Find(id);
                c.Name = name;
                db.SaveChanges();
            }
        }
        public void DeleteCompany(int id)
        {
            using (_DbContext db = new _DbContext())
            {
                Company c = db.Companies.Find(id);
                db.Remove(c);
                db.SaveChanges();
            }
        }


    }
}
