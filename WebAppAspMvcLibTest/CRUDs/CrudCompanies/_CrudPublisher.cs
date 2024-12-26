using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class _CrudPublisher:_CrudCompany
    {
        public override void CreateCompany(string name)
        {
            using (_DbContext db = new _DbContext())
            {
                Publisher c = new Publisher();
                c.Name = name;
                db.Publishers.Add(c);
                db.SaveChanges();
            }
        }


    }
}
