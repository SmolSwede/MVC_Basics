using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using MVC_Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Controlles
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Prodjects()
        {
            return View();
        }

        [HttpGet]
        public IActionResult GuessingGame()
        {
            if(HttpContext.Session.GetInt32("NumberToGuess") == null)
            {
                HttpContext.Session.SetInt32("NumberToGuess", NumberGuessingGame.GenerateNum());
            }
            return View();
        }

        [HttpPost]
        public IActionResult GuessingGame(int inputNum)
        {
            ViewBag.Message = inputNum + " " + HttpContext.Session.GetInt32("NumberToGuess") + " " + NumberGuessingGame.GuessCheck(inputNum, out bool win);

            if(win == true)
            {
                HttpContext.Session.SetInt32("NumberToGuess", NumberGuessingGame.GenerateNum());
            }
            return View();
        }
    }
}
