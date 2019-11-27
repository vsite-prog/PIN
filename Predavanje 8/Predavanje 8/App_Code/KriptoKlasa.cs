using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for KriptoKlasa
/// </summary>
public class KriptoKlasa
{
       public static string Kriptiraj(string txt)
    {
        // Ovo je klasa sa algoritmom
        SHA256Managed SHA = new SHA256Managed();
        // ComputeHash traži bajtove pa idemo konvertirati u polje bajtova
        byte[] bajtovi = UTF8Encoding.UTF8.GetBytes(txt);
        // ...   polje bajtova
        byte[] hashiraniBajtovi = SHA.ComputeHash(bajtovi);

        return Convert.ToBase64String(hashiraniBajtovi);
    }
}