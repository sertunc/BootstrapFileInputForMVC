﻿using BootstrapFileInput.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BootstrapFileInput.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeVM model = new HomeVM();

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(HomeVM model)
        {
            return View(model);
        }
    }
}
