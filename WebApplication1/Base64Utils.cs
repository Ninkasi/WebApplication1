using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public static class Base64Dekooderi
    {
        public static string EnkoodaaTeksti(string teksti)
        {
            byte[] puskuri = System.Text.Encoding.UTF8.GetBytes(teksti);
           
            return Convert.ToBase64String(puskuri);
        }

        public static string DekoodaaTeksti(string teksti)
        {
            byte[] puskuri = Convert.FromBase64String(teksti);
            
            return System.Text.Encoding.UTF8.GetString(puskuri);
        }
    }
}