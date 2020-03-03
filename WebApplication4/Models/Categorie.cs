using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;

namespace WebApplication4.Models
{
    public class Categorie
    {
        public int Id { get; set; }

        public string libelle { get; set; }

        public Categorie()
        {

        }

        public static List<Categorie> GetAllCategories()
        {
            string url = System.Configuration.ConfigurationSettings.AppSettings["URLApi"] + "Categorie";
            var request = (HttpWebRequest)WebRequest.Create(url);
            var listeCategorie = new List<Categorie>();
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
                dynamic categorie = JObject.Parse(jsonArray[i].ToString());
                listeCategorie.Add(categorie.ToObject(typeof(Categorie)));
            }

            return listeCategorie;
        }
    }
}