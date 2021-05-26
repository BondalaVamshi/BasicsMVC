using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace DemoMVC.Controllers
{
    public class HelloController : Controller
    {
        // GET: Hello
        public ActionResult Index()
        {
            return View();
        }
        public string Wish()
        {
            return "this is welcome message from Controller";
        }
        public string Details(string name, int Id = 1)
        {
            return HttpUtility.HtmlEncode("Id="+Id+" hello  "+name);
        }
        public string Address(string village,string name="Albert", int Id = 1)
        {
            return HttpUtility.HtmlEncode("Id=" + Id + " village is"+village+" hello  " + name);
        }

        //Passing Data from the Controller to the View
        public ActionResult Welcome(string name, int Id = 1)
        {
            ViewBag.Name = "hello " + name;
            ViewBag.ID = Id;
            return View();
        }

        public ActionResult MovieDetails()
        {
            var movie = new ModelMovie() { ID = 1, Title = "amazing", Genre = "adventure", ReleaseDate = DateTime.Now };
            return View();
        }

        //private ActionResult View(Func<ActionResult> index)
        //{
        //    throw new NotImplementedException();
        //}
    }
}