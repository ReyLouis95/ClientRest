using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApplication4.Models
{
    public class Produit
    {
        public int Id { get; set; }

        // nom
        public string Nom { get; set; }

        public string Categorie { get; set; }

        public double Prix { get; set; }

        public string Description { get; set; }

        public int QuantiteStock { get; set; }

        public Produit()
        {

        }

        public Produit(int id, string nom, string categorie, double prix, string description, int quantiteStock)
        {
            Id = id;
            Nom = nom;
            Categorie = categorie;
            Prix = prix;
            Description = description;
            QuantiteStock = quantiteStock;
        }

        /// <summary>
        /// retourne la liste de tous les velos du webservice
        /// </summary>
        /// <returns></returns>
        public static List<Produit> getAllVelos()
        {
            string url = System.Configuration.ConfigurationSettings.AppSettings["URLApi"] + "Velo";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var listeVelo = new List<Produit>();
            request.Method = "GET";
            var content = string.Empty;
            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var sr = new StreamReader(stream))
                        {
                            content = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            JArray jsonArray = JArray.Parse(content);
            for (int i = 0; i < jsonArray.Count(); i++)
            {
                dynamic velo = JObject.Parse(jsonArray[i].ToString());
                listeVelo.Add(velo.ToObject(typeof(Produit)));
            }
            return listeVelo;
        }

        /// <summary>
        /// retourne la liste de velo en fonction de la categorie
        /// </summary>
        /// <param name="id">id de la categorie</param>
        /// <returns>liste de velo</returns>
        public static List<Produit> GetVeloByCateg(int id)
        {
            string url = System.Configuration.ConfigurationSettings.AppSettings["URLApi"] + "Velo/Categorie/" + id;
            var request = (HttpWebRequest)WebRequest.Create(url);
            var listeVelo = new List<Produit>();
            request.Method = "GET";
            var content = string.Empty;
            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var sr = new StreamReader(stream))
                        {
                            content = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            JArray jsonArray = JArray.Parse(content);
            for (int i = 0; i < jsonArray.Count(); i++)
            {
                dynamic velo = JObject.Parse(jsonArray[i].ToString());
                listeVelo.Add(velo.ToObject(typeof(Produit)));
            }
            return listeVelo;
        }

        public static Produit GetVeloById(int id)
        {
            string url = System.Configuration.ConfigurationSettings.AppSettings["URLApi"] + "Velo/" + id;
            var request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            var content = string.Empty;
            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var sr = new StreamReader(stream))
                        {
                            content = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

            dynamic velo = JObject.Parse(content.ToString());
            velo = velo.ToObject(typeof(Produit));
            return velo;
        }

        public static void DeleteProduit(int id, int nbCommandes)
        {
            string url = System.Configuration.ConfigurationSettings.AppSettings["URLApi"] + "Velo/" + id;
            var request = (HttpWebRequest)WebRequest.Create(url);
            var content = string.Empty;
            request.ContentType = "application/json";
            request.Method = "PATCH";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                int nbCommande = nbCommandes;

                streamWriter.Write(nbCommande);
                streamWriter.Close();
            }
            try
            {
                using (var response = (HttpWebResponse)request.GetResponse())
                {
                    using (var stream = response.GetResponseStream())
                    {
                        using (var sr = new StreamReader(stream))
                        {
                            content = sr.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}