using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Panier
    {
        public List<Produit> ListeProduit;
        public double prix;

        public Panier()
        {
            ListeProduit = new List<Produit>();
            prix = 0;
        }

        public static Panier AjoutProduit(Produit produit, Panier panier)
        {
            panier.ListeProduit.Add(produit);
            panier.prix = panier.prix + produit.Prix * produit.QuantiteStock;
            return panier;
        }
    }
}