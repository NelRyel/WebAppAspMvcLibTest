using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class _CrudStudio_Movie_Series_Animated
    {
        public void CreateStudio_Movie_Series_Animated(string name)
        {
            using (_DbContext db = new _DbContext())
            {
                Studio_Movie_Series_Animated c = new Studio_Movie_Series_Animated();
                c.Name = name;
                db.Studios.Add(c);
                db.SaveChanges();
            }
        }
        public void UpdatePublisher(string name, int id)
        {
            using (_DbContext db = new _DbContext())
            {
                Studio_Movie_Series_Animated c = db.Studios.Find(id);
                c.Name = name;
                db.SaveChanges();
            }
        }
        public void DeletePublisher(int id)
        {
            using (_DbContext db = new _DbContext())
            {
                Studio_Movie_Series_Animated c = db.Studios.Find(id);
                db.Remove(c);
                db.SaveChanges();
            }
        }



    }
}
