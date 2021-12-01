using Microsoft.AspNetCore.Mvc;

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
