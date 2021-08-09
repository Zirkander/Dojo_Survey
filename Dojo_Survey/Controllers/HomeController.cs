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

        [HttpPost("Results")]
        public IActionResult Results(Person person)
        {
            return View("Results", person);
        }
    }
}