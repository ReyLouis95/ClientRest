using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class RecapCommandeController : Controller
    {
        // GET: RecapCommande
        public ActionResult Index(Client client)
        {
            Session["Client"] = client;
            Panier panier = (Panier)Session["Panier"];
            foreach (Produit produit in panier.ListeProduit)
            {
                Produit.DeleteProduit(produit.Id, produit.QuantiteStock);
            }
            return View();
        }

    }
}