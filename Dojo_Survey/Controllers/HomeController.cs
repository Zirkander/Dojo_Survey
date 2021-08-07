using System;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Results()
        {
            return View("Results");
        }
    }
}