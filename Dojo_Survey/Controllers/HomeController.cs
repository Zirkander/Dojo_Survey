using Microsoft.AspNetCore.Mvc;
using Dojo_Survey.Models;

namespace Dojo_Survey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }

        [HttpPost("results")]
        public IActionResult Results(Person person)
        {
            if (ModelState.IsValid)
            {
                return View("Results", person);
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet("NewUser")]
        public IActionResult NewUser()
        {
            return View("NewUser");
        }

        [HttpPost("FormResults")]
        public IActionResult FormResults(User newUser)
        {
            if (ModelState.IsValid)
            {
                return View("FormResults", newUser);
                // HttpContext.Session.SetString("Username", newUser.Username);
                // return RedirectToAction("FormResults");
            }
            else
            {
                return View("NewUser");
            }
        }
    }
}