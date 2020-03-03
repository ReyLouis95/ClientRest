using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication4.Models
{
    public class Outils
    {
        public static string trimJson(string s)
        {
            return s.TrimStart(new char[] { '[' }).TrimEnd(new char[] { ']' });
        }
    }
}