using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

/// <summary>
/// Summary description for Util
/// </summary>
public static  class Util
{
    public static string hash(string tekst)
    {
        //SHA hashing algorithm 
        SHA256Managed algoritam = new SHA256Managed();
        //Get bytes from string
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(tekst);
        //Execute hashing
        byte[] resultBytes = algoritam.ComputeHash(bytes);
        //return as string
        return Convert.ToBase64String(resultBytes);

    }
}