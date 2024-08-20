using Microsoft.AspNetCore.Mvc;

namespace webmvctask.Controllers
{
    public class StudentsController : Controller
    {
      
        public IActionResult GetAll()
        {
            return View();
        }
        public IActionResult GetId(int id)
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Update(int id)
        {
            return View();
        }

        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
