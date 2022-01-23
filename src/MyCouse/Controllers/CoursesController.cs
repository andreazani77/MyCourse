using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCouse.Controllers
{
    public class CoursesController : Controller
    {
        public IActionResult Index()
        {
            //cercherà una views contenuta nella cartella views\courses\index
            return View();
        }

        public IActionResult Detail(string id)
        {
            return View();
        }

        public IActionResult Search(string title)
        {
            return Content($"Hai cercato {title}");
        }


    }
}
