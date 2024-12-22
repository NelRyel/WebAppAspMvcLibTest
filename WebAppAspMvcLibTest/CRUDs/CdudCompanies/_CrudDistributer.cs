using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class _CrudDistributer
    {
        public void CreateDistributer(string name)
        {
            using (_DbContext db = new _DbContext())
            {
                Distributer c = new Distributer();
                c.Name = name;
                db.Distributers.Add(c);
                db.SaveChanges();
            }
        }
        public void UpdateDistributer(string name, int id)
        {
            using (_DbContext db = new _DbContext())
            {
                Distributer c = db.Distributers.Find(id);
                c.Name = name;
                db.SaveChanges();
            }
        }
        public void DeleteDistributer(int id)
        {
            using (_DbContext db = new _DbContext())
            {
                Distributer c = db.Distributers.Find(id);
                db.Remove(c);
                db.SaveChanges();
            }
        }



    }
}
