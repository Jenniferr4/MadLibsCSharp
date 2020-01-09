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
        [Route("/")]
        public IActionResult Index(string Adjective, string Verbing1, string BookChar1, 
                                   string Verbing2, string BookChar2, 
                                   string HomeT, string BookChar3, string Title, string Name1,
                                   string State, string Name2, string Onomonopia, string PastVerb, int Number)
        {
            madLibsWordsViewModel myMadLibs = new madLibsWordsViewModel();
            myMadLibs.Adjective = Adjective;
            myMadLibs.Verb_ing1 = Verbing1;
            myMadLibs.BookChar1 = BookChar1;
            myMadLibs.Verb_ing2 = Verbing2;
            myMadLibs.BookChar2 = BookChar2;
            myMadLibs.HomeTown = HomeT;
            myMadLibs.BookChar2 = BookChar3;
            myMadLibs.Title = Title;
            myMadLibs.Name1 = Name1;
            myMadLibs.State = State;
            myMadLibs.Name2 = Name2;
            myMadLibs.Onomonopia = Onomonopia;
            myMadLibs.PastVerb = PastVerb;
            myMadLibs.Number = Number;

            return View(myMadLibs);
        }

        [Route("/body")]
        public IActionResult Body(string Adjective, string Verbing1, string BookChar1,
                                   string Verbing2, string BookChar2,
                                   string HomeT, string BookChar3, string Title, string Name1,
                                   string State, string Name2, string Onomonopia, string PastVerb, int Number)
        {
            madLibsWordsViewModel myMadLibs = new madLibsWordsViewModel();
            myMadLibs.Adjective = Adjective;
            myMadLibs.Verb_ing1 = Verbing1;
            myMadLibs.BookChar1 = BookChar1;
            myMadLibs.Verb_ing2 = Verbing2;
            myMadLibs.BookChar2 = BookChar2;
            myMadLibs.HomeTown = HomeT;
            myMadLibs.BookChar3 = BookChar3;
            myMadLibs.Title = Title;
            myMadLibs.Name1 = Name1;
            myMadLibs.State = State;
            myMadLibs.Name2 = Name2;
            myMadLibs.Onomonopia = Onomonopia;
            myMadLibs.PastVerb = PastVerb;
            myMadLibs.Number = Number;
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
