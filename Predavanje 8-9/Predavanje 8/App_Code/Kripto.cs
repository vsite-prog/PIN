using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography; //Tu je sve što trebamo za hashiranje
using System.Text; // Hashiranje radi s byteovima

/// <summary>
/// Assembli definicija: Kripto funkcija za hashiranje
/// </summary>
/// Statička klasa, spremnik koda
public static class Kripto
{
    //Statička metoda koja nema veze s objektima već je na nivou klasu
    public static string Hash(string str)
    {
        // Text u polje bajtova
        byte[] bajtovi = Encoding.UTF8.GetBytes(str);
        // Sada mi treba funkcija za hashiranje
        SHA256Managed sHA = new SHA256Managed();
        // Sad hashiraj bajtove
        bajtovi = sHA.ComputeHash(bajtovi);
        // Sad opet pretvori u string
        return Convert.ToBase64String(bajtovi);
    }
}