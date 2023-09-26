using Microsoft.AspNetCore.Mvc;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return Content("Данные из первого контроллера");
            return View();
        }
        public string ConfiguredAction(string id)
        {
            return $"hi hello {id}";
        }
    }
}
