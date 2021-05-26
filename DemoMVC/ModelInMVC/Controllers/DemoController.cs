using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelInMVC.Models;

namespace ModelInMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            var data = employee();
            return View(data);
        }
        private Employee employee()
        {
            return new Employee()
            {
                Id = 1,
                Name = "Hello",
                Sal = 1000
            };
        }
    }
    
}