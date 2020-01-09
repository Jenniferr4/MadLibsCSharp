using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MadLibsCSharp.Models;

namespace MadLibsCSharp.Controllers
{
    public class HomeController : Controller
    {
        [Route("/hello")]
        public string Hello() { return "Hello friend!"; }

        [Route("/goodbye")]
        public string Goodbye() { return "Goodbye friend."; }

        [Route("/form")]
        public IActionResult Form() { return View(); }

        [Route("/body")]
        public IActionResult Body(string color, string verb, string adjective, string noun)
        {
            madLibsWordsViewModel myMadLibs = new madLibsWordsViewModel();
            myMadLibs.Color = color;
            myMadLibs.Verb = verb;
            myMadLibs.Adjective = adjective;
            myMadLibs.Noun = noun;
            return View(myMadLibs);
        }


        [Route("/")]
        public IActionResult Index(string color, string verb, string adjective, string noun)
        {
            madLibsWordsViewModel myMadLibs = new madLibsWordsViewModel();
            myMadLibs.Color = color;
            myMadLibs.Verb = verb;
            myMadLibs.Adjective = adjective;
            myMadLibs.Noun = noun;
            
            return View(myMadLibs);
        }
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
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
