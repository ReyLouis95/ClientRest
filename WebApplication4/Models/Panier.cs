using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Panier
    {
        public List<Produit> ListeProduit;

        public Panier()
        {
            ListeProduit = new List<Produit>();
        }

        public static Panier AjoutProduit(Produit produit, Panier panier)
        {
            panier.ListeProduit.Add(produit);
            return panier;
        }
    }
}