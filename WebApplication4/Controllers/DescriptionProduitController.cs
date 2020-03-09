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

        /// <summary>
        /// Ajoute un produit dans le panier
        /// </summary>
        /// <param name="produit">produit à ajouter</param>
        /// <returns>success si l'ajout s'est bien réalisé</returns>
        public ActionResult AjouterProduitPanier(Produit produit)
        {
            Session["Panier"] = Panier.AjoutProduit(produit, (Panier)Session["Panier"]);
            return Json(new { Response = "Success" });
        }
    }
}