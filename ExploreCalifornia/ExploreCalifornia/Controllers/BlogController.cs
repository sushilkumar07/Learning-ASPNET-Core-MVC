using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    public class BlogController : Controller
    {
        [Route("blog/")] // Controller level attribute routing 
        public IActionResult Index()
        {
            //return new ContentResult { Content = "Blog post" };
            return View();
        }

        /*model binding*/
        public IActionResult Post(string id)
        {
            /*View bag is the dyamic object*/
            ViewBag.Title = "First blog mvc learining";
            ViewBag.Posted = DateTime.Now;
            ViewBag.Author = "Sushilkumar Shinde";
            ViewBag.Body = "This is learning blog... keep doing practices";
            //return new ContentResult { Content = id };
            return View();
        }
        //[Route("blog/{year:int}/{month:int}/{key}")]
        //public IActionResult Post(int year, int month, string key)
        //{
        //    return new ContentResult { Content = "blog" + string.Format("year:{0}; month:{1}; key :{2}", year, month, key) };
        //    //return View();
        //}
        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]  // Controller level attribute routing  with contrain
        public IActionResult Post(int year, int month, string key)
        {
            return new ContentResult { Content = "blog" + string.Format("year:{0}; month:{1}; key :{2}", year, month, key) };
            //return View();
        }

    }
}
