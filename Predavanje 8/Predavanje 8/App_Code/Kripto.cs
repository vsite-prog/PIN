using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

/// <summary>
/// Summary description for Kripto
/// </summary>
public static class Kripto
{
    public static string Hashiraj(string s)
    {
        // Funkcija za hash-iranje
        SHA256Managed sha = new SHA256Managed(); // Kriptitor
                                                 // Pretvori text u polje bytove
        byte[] poljeBajtova = UTF8Encoding.UTF8.GetBytes(s);
        byte[] hashiranoPoljeBajtova = sha.ComputeHash(poljeBajtova); // Hashirati ću ali mi treba polje byte-ove

        return Convert.ToBase64String(hashiranoPoljeBajtova); // Vrati nazad tekst
    }
}