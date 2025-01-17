﻿using WebAppAspMvcLibTest.ContextModel;
using WebAppAspMvcLibTest.entModels.Companies;

namespace WebAppAspMvcLibTest.CRUDs.CdudCompanies
{
    public class _CrudDeveloper: _CrudCompany
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
        //public void UpdateDeveloper(string name, int id)
        //{
        //    using (_DbContext db = new _DbContext())
        //    {
        //        Developer developer = db.Developers.Find(id);
        //        developer.Name = name;
        //        db.SaveChanges();
        //    }
        //}
        //public void DeleteDeveloper(int id)
        //{
        //    using (_DbContext db = new _DbContext())
        //    {
        //        Developer developer = db.Developers.Find(id);
        //        db.Remove(developer);
        //        db.SaveChanges();
        //    }
        //}
    }
}
