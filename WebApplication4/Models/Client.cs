using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Client
    {
        public Client() { }

        [Required(ErrorMessage ="Nom obligatoire")]
        public string Nom { get; set; }

        [Required]
        public string Prenom { get; set; }

        [Required]
        [EmailAddress]
        public string Mail { get; set; }


        public Client(int id, string nom, string prenom, string mail)
        {
            Nom = nom;
            Prenom = prenom;
            Mail = mail;
        }
    }
}