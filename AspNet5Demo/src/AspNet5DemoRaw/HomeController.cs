using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AspNet5DemoRaw
{
    public class HomeController : Controller
    {
        public string Index()
        {
            return "Hello from Controller";
        }
    }
}
