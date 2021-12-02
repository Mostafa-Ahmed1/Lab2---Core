using Microsoft.AspNetCore.Mvc;
using Lab2___Core.Models;

namespace Lab2___Core.Controllers
{
    public class StudentController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
