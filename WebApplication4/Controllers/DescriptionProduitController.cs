using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class DescriptionProduitController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">id du produit</param>
        /// <returns>Objet Velo en fonction de l'id</returns>
        public ActionResult DescriptionProduit(int id)
        {
            Produit velo = Produit.GetVeloById(id);
            return View(velo);
        }
    }
}