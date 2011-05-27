using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MobileBlog.Models;

namespace MobileBlog.Controllers
{
    public class HomeController : Controller
    {
        PostDBContext db = new PostDBContext();

        public ActionResult Index()
        {
            ViewBag.HeaderString = "Welcome!";
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.HeaderString = "Create New Post";
            return View();
        }

        public ActionResult Read()
        {
            ViewBag.HeaderString = "Read Blog";

            var posts = from p in db.Posts
                        select p;

            return View(posts.ToList());
        }

        public ActionResult About()
        {
            ViewBag.HeaderString = "About MobileBlog";
            return View();
        }

        [AcceptVerbs(HttpVerbs.Post)]
        public string SavePost(string title, string content)
        {
            Post post = new Post();
            post.Title = title;
            post.Content = content;
            post.PublishDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                db.Posts.Add(post);
                db.SaveChanges();
                return "SUCCESS";
            }
            else
            {
                return "FAILED";
            }
        }
    }
}
