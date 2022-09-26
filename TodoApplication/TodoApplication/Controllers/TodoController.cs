using Microsoft.AspNetCore.Mvc;

namespace TodoApplication.Controllers
{
    public class TodoController : Controller
    {

        public IActionResult Index()
        {
            
            
            return View();
        }

        [HttpPost]
        public ActionResult Create(Models.TodoApp td)
        {
            ViewBag.id = td.Id;
            ViewBag.Name = td.Name;
            ViewBag.Number = td.Number;

            return View("Index");
        }



    }
}
