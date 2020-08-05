﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExploreCalifornia.dbcontext;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExploreCalifornia.Controllers
{
    public class BlogController : Controller
    {
        private readonly BlogDataContext _db;
        public BlogController(BlogDataContext db)
        {
            _db = db;
        }
        [Route("blog/")] // Controller level attribute routing 
        public IActionResult Index()
        {
            //return new ContentResult { Content = "Blog post" };
            return View();
        }



        /*model binding*/
        public IActionResult Post(string id)
        {
            /*Render data with strongly typed view we are using Model instend of viewbag*/
            var post = new Post
            {
                Author = "Sushilkumar Shinde",
                Title = "First blog mvc learining",
                Body = "This is learning blog... keep doing practices",
                Posted = DateTime.Now
            };
            /*View bag is the dyamic object*/
            //ViewBag.Title = "First blog mvc learining";
            //ViewBag.Posted = DateTime.Now;
            //ViewBag.Author = "Sushilkumar Shinde";
            //ViewBag.Body = "This is learning blog... keep doing practices";
            //return new ContentResult { Content = id };
            return View(post);
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

        [HttpGet, Route("blog/create")]
        public IActionResult Create()
        {

            return View();
        }

        [HttpPost, Route("blog/create")]

        public IActionResult Create(Post post)
        {
            if (!ModelState.IsValid)
                return View();

            post.Author = User.Identity.Name;
            post.Posted = DateTime.Now;

            _db.Posts.Add(post);
            _db.SaveChanges();
            return View();
        }
    }
}
