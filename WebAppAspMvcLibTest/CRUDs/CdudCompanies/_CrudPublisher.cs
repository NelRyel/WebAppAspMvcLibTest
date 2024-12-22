using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class _CrudPublisher
    {
        public void CreatePublisher(string name)
        {
            using (_DbContext db = new _DbContext())
            {
                Publisher c = new Publisher();
                c.Name = name;
                db.Publishers.Add(c);
                db.SaveChanges();
            }
        }
        public void UpdatePublisher(string name, int id)
        {
            using (_DbContext db = new _DbContext())
            {
                Publisher c = db.Publishers.Find(id);
                c.Name = name;
                db.SaveChanges();
            }
        }
        public void DeletePublisher(int id)
        {
            using (_DbContext db = new _DbContext())
            {
                Publisher c = db.Publishers.Find(id);
                db.Remove(c);
                db.SaveChanges();
            }
        }


    }
}
