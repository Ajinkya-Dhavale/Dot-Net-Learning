// File: Controllers/StudentController.cs
using Microsoft.AspNetCore.Mvc;
using StudentTestApp.Models;

namespace StudentTestApp.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Student student)
        {
            // Handle form submission logic here
            // For example, save the student data to a database

            // Redirect to a confirmation page or display a success message
            return RedirectToAction("Index");
        }
    }
}
