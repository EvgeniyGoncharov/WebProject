using Microsoft.AspNetCore.Mvc;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class HomeController : Controller
    {
        private static readonly List<Employee> __Employees = new()
        {
            new Employee { Id = 1, LastName = "борис", FirstName = "борисов", Age = 20},
            new Employee { Id = 2, LastName = "пётр", FirstName = "петров", Age = 25},
            new Employee { Id = 3, LastName = "антон", FirstName = "антонов", Age = 30},
        };
        public IActionResult Index()
        {
            //return Content("Данные из первого контроллера");
            return View();
        }
        public string ConfiguredAction(string id)
        {
            return $"hi hello {id}";
        }

        public IActionResult Employees()
        {
            return View(__Employees);
        }
    }
}
