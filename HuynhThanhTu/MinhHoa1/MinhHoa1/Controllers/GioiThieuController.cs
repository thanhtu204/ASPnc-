using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MinhHoa1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhHoa1.Controllers
{
    public class GioiThieuController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult My()
        {
            return View();
        }
        public IActionResult AnhChiEm()
        {
            return View();
        }
        public IActionResult ChaMe()
        {
            return View();
        }


    }
}
