using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class ListeProduitsController : Controller
    {
        // GET: ListeProduits
        public ActionResult ListeProduits(int id)
        {
            ViewBag.listeVelos = Velo.GetVeloByCateg(id);
            return View();
        }
    }
}