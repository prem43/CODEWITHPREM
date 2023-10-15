using CODEWITHPREM.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CODEWITHPREM.Controllers
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
            return View();
        }
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SubmitSignUp(string username, string password)
        {
            // Handle the submitted user details, e.g., store them in a database

            // For simplicity, just return a success message
            return Content("Sign Up successful. Username: " + username + ", Password: " + password);
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