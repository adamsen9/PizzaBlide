﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pizzablide.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "I just want to be part of your sympohony";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";


            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
