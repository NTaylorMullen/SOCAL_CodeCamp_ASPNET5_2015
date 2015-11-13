using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace AspNet5DemoRaw
{
    public class HomeController : Controller
    {
        private readonly StringMagicUtility _magicUtility;

        public HomeController(StringMagicUtility magicUtility)
        {
            _magicUtility = magicUtility;
        }

        public string Index()
        {
            return "Hello from Controller";
        }

        public string Magic()
        {
            return "From magic:" + _magicUtility.Magic();
        }
    }
}
