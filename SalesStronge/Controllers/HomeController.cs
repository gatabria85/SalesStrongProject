﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SalesStronge.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Tu decripción de aplicación.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Tu pagina de contacto.";

            return View();
        }
    }
}