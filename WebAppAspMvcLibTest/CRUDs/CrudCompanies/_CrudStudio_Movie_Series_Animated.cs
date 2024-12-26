using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class _CrudStudio_Movie_Series_Animated: _CrudCompany
    {
        public override void CreateCompany(string name)
        {
            using (_DbContext db = new _DbContext())
            {
                Studio_Movie_Series_Animated c = new Studio_Movie_Series_Animated();
                c.Name = name;
                db.Studios.Add(c);
                db.SaveChanges();
            }
        }


    }
}
