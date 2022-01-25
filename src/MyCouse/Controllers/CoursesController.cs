using Microsoft.AspNetCore.Mvc;
using MyCouse.Models.Services.Application;
using MyCouse.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCouse.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ICourseService courseService;

        //Serve per fare accoppiamentio debole tramnite dependency injection
        //nella startup si specifica con quale classe andrà implementata l'interfaccia ICourseService
        public CoursesController(ICourseService courseService)
        {
            this.courseService = courseService;
        }

        public IActionResult Index()
        {
            //cercherà una views contenuta nella cartella views\courses\index
            var courseService = new CourseService();
            List<CourseViewModel> courses = courseService.GetCourses();
            ViewData["Title"] = "Catalogo dei corsi"; //Verrà utilizzato dalla view di layout per impostare il titolo
            return View(courses);
        }

        public IActionResult Detail(int id)
        {
            var courseService = new CourseService();
            CourseDetailViewModel viewModel = courseService.GetCourse(id);
            ViewData["Title"] = viewModel.Title; //Verrà utilizzato dalla view di layout per impostare il titolo
            return View(viewModel);
        }

        public IActionResult Search(string title)
        {
            return Content($"Hai cercato {title}");
        }


    }
}
