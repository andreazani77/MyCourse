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
            return Content("Sono index");
        }

        public IActionResult Detail(string id)
        {
            return Content($"Sono detail, ho ricevuto l'id {id}");
        }

    }
}
