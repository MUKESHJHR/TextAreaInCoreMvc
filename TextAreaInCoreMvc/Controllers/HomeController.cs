using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TextAreaInCoreMvc.Models;

namespace TextAreaInCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Employee emp = new Employee()
            {
                EmployeeId = 101,
                EmployeeName = "Mukesh Kumar",
                Address = "Jharkhand",
                City = "Hazaribagh",
                Gender = "Male",
                Salary = 50000,
                Password = "Test"
            };
            return View(emp);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}