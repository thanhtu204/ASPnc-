using Microsoft.AspNetCore.Mvc;
using MinhHoa1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace MinhHoa1.Controllers
{
    public class TinhToan : Controller
    {
        public IActionResult Index()
        {   
            return View();
        }
        //public IActionResult XuLy(double so1,double so2,string pt)
        //{
        //    double kq = 0;
        //    switch (pt)
        //    {
        //        case "+" :kq = so1 + so2; break;
        //        case "-": kq = so1 - so2; break;
        //        case "*": kq = so1 * so2; break;
        //        case "/": kq = so1 / so2; break;
        //    }
        //    ViewBag.kq = kq;

        //    return View();
        //}
     
        
        public IActionResult XuLy(TinhToanModel tt)
        {
          
            ViewBag.kq = tt.ketqua();

            return View("Index");
        }
    }
}
