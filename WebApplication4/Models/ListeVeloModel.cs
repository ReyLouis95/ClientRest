using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class ListeVeloModel
    {
        public List<Produit> ListeVelos { get; set; }

        public ListeVeloModel()
        {

        }

        public ListeVeloModel(List<Produit> listeVelos)
        {
            ListeVelos = listeVelos;
        }
    }
}