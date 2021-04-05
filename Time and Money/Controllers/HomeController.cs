using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using Time_and_Money.Models;
using Activity = Time_and_Money.Models.Activity;

namespace Time_and_Money.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult NewUser()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddActivity()
        {
            return View();
        }

        [HttpPost]

        public IActionResult AddActivity(Activity a)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("AddActivity", a);
            }
            return View(a);
        }

        [HttpGet]

        public IActionResult EditActivity(int id)
        {
            // need to : use "id" to go to the data base and get an education record
            // for now fake it
            Activity ab = new Activity();
            ab.activity = "work";
            return View(ab);
        }

        [HttpPost]
        public IActionResult EditActivity(Activity updatedActivity)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("ActivityDetails", updatedActivity);
            }
            return View(updatedActivity);
        }
        public IActionResult ActivityDetails(Activity a)
        {
            return View(a);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = System.Diagnostics.Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
