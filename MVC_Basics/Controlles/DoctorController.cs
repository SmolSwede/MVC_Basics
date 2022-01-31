using Microsoft.AspNetCore.Mvc;
using MVC_Basics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Basics.Controlles
{
    public class DoctorController : Controller
    {
        [HttpGet]
        public IActionResult FeverCheck()
        {
            return View();
        }


        [HttpPost]
        public IActionResult FeverCheck(int inputTemp)
        {
            ViewBag.Message = FeverChecker.Check(inputTemp);
            return View();
        }

    }
}
