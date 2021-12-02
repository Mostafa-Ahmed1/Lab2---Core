using Microsoft.AspNetCore.Mvc;
using Lab2___Core.Models;

namespace Lab2___Core.Controllers
{
    public class StudentController : Controller
    {
        ITIContext db;

        public StudentController(ITIContext db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            return View(db.Students.ToList());
        }
    }
}
