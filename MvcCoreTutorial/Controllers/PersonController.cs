using Microsoft.AspNetCore.Mvc;

namespace MvcCoreTutorial.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            //ViewBag and View Data can send data only from ControllerToView
            ViewBag.greeting = "Hello World!";
            ViewData["greeting2"] = "I am using ViewData";
            

            //Tempdata can send data from one controller method to another controller method
            TempData["greeting3"] = "It's TempData msg";
            return View();
        }

        //it is a get method
        public IActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddPerson(PersonController person)
        {
            return View();
        }
    }
}
