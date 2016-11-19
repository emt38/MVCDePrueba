﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AplicacionNueva.Models;
using System.Web.Mvc;

namespace AplicacionNueva.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}