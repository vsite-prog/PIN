using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Lista
/// </summary>
public static class Lista
{
    // Privatna lista, imitacija tablice u bazi
    static List<Korisnik> lista = new List<Korisnik>()
    {
        new Korisnik ("Ana Anić", "123"),
        new Korisnik("Ivo Anić", "1234"),
        new Korisnik ("Mario Ivić", "123")
    };

    // Statična klasa se ne koristi za objekte nego samo grupira proccedure

    public static bool ImaKorisnika(string ime, string lozinka)
    {
        //Ide petljom 
        foreach (Korisnik korisnik in lista)
        {
            if (korisnik.Ime == ime && korisnik.Lozinka == lozinka)
                return true;
        }
        //Nema ge
        return false;
    }
}