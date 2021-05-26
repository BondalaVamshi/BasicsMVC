using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoMvc1.Models
{
    public class MovieController : Controller
    {
        public string Index()
        {
            return "Hello world ";
        }
    }
}
