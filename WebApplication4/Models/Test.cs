using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace WebApplication4.Models
{
    public class Test
    {
        public static string GetVelo()
        {
            string a = "";
            using (var conn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connexionBdD"].ConnectionString))
            {
                conn.Open();
                string req = "select * from produits";
                try
                {
                    var commande = new MySqlCommand(req, conn);
                    MySqlDataReader lecteur = commande.ExecuteReader();
                    while (lecteur.Read())
                    {
                        a = lecteur.GetString(1);
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }

            return a;
        }

        
    }
}