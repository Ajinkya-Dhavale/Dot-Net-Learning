// File: Controllers/HomeController.cs
using Microsoft.AspNetCore.Mvc;
using StudentTestApp.Models;

namespace StudentTestApp.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            // Pass the submitted data back to the view
            return View(student);
        }
    }
}
