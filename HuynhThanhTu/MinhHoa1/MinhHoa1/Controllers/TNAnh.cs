using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using MinhHoa1.Models;
namespace MinhHoa1.Controllers
{
    
    public class TNAnh : Controller
    {
        private IHostingEnvironment hosting;

      public TNAnh(IHostingEnvironment _hosting)
        {
            hosting = _hosting;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult XuLy(Person m,IFormFile FHinh)
        {
            if (FHinh != null)
            {
                //xuly 
                // string filename = FHinh.FileName;
                string filename = Guid.NewGuid().ToString() + Path.GetExtension(FHinh.FileName);
                //string path = hosting.WebRootPath + "/img"; 
                string path = Path.Combine(hosting.WebRootPath + "/img");
                using (var filestream = new FileStream(Path.Combine(path, filename), FileMode.Create))
                {
                    //sao chep len server
                    FHinh.CopyTo(filestream);
                }
                m.Picture = filename;
            }
            return View(m);
        }

    }
}
