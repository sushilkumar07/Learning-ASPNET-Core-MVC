using ExploreCalifornia.dbcontext;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;

namespace ExploreCalifornia.ViewComponets
{
    [ViewComponent]
    public class MonthlySpecialViewComponent : ViewComponent
    {
        private readonly BlogDataContext _db;
        //public string Invoke()
        //{
        //    return "TODO : Show monthly specials from View-Component"; 
        //}
        public MonthlySpecialViewComponent(BlogDataContext db)
        {
            this._db = db;
        }
        public IViewComponentResult Invoke()
        {
            var special = _db.MonthlySpecials.ToArray();
            return View(special);
        }


    }
}
