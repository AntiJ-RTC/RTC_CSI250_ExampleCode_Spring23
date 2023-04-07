using IntroToDotNet.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
//We are in a project named IntroToDotNet in a folder called Controllers
namespace IntroToDotNet.Controllers
{
    //THis is the HomeController class which inherits from Controller
    public class HomeController : Controller
    {
        //Field
        private readonly ILogger<HomeController> _logger;
        //Constructor
        //Assigns values to the fields
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Actions - It's just a method
        //IActionResult
        //I go to /Home/Index
        //It is the default path
        //Home is the default controller, Index is the default action
        public IActionResult Index()
        {
            //Look for html at /Views/Home/Index.cshtml
            return View();
        }
        //I go to /Home/Privacy
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