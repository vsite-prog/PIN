using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for Util
/// </summary>
public static class Util
{
    public static string hashHash(string pojam)
    {
        //Racunam dajte mi string da ga hashiram
        SHA256Managed sha = new SHA256Managed();
        //Treba mi polje bajtova za hashiranje
        byte[] poljeBajtova = Encoding.UTF8.GetBytes(pojam);
        //sad možemo hashirati
        byte[] rezultat = sha.ComputeHash(poljeBajtova);

        //vrati nazad kao string
        return Convert.ToBase64String(rezultat);
    }
}