using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class _CrudProduction
    {
        public void CreateProduction(string name)
        {
            using (_DbContext db = new _DbContext())
            {
                Production c = new Production();
                c.Name = name;
                db.Productions.Add(c);
                db.SaveChanges();
            }
        }
        public void UpdateDistributer(string name, int id)
        {
            using (_DbContext db = new _DbContext())
            {
                Production c = db.Productions.Find(id);
                c.Name = name;
                db.SaveChanges();
            }
        }
        public void DeleteDistributer(int id)
        {
            using (_DbContext db = new _DbContext())
            {
                Production c = db.Productions.Find(id);
                db.Remove(c);
                db.SaveChanges();
            }
        }
    }
}
