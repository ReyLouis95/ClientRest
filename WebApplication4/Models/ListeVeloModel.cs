using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class ListeVeloModel
    {
        public List<Velo> ListeVelos { get; set; }

        public ListeVeloModel(List<Velo> listeVelos)
        {
            ListeVelos = listeVelos;
        }
    }
}