﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class AccueilController : Controller
    {
        // GET: Accueil
        public ActionResult Index() {
            var session = Session["Panier"];
            return View();
        }
    }
}