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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id de la categorie</param>
        /// <returns>la liste de velos correpondante à la categorie</returns>
        public ActionResult ListeProduits(int id)
        {
            var listeVelos = new ListeVeloModel
            {
                ListeVelos = Produit.GetVeloByCateg(id),
            };
            return View(listeVelos);
        }
    }
}