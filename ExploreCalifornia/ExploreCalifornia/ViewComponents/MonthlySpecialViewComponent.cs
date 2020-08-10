using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExploreCalifornia.ViewComponets
{
    [ViewComponent]
    public class MonthlySpecialViewComponent : ViewComponent
    {
        public string Invoke()
        {
            return "TODO : Show monthly specials from View - Component"; 
        }

    }
}
