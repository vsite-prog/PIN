using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Korisnik
/// </summary>
public class Korisnik
{
    //Ovo nije baš zgodno, nema promjene
    // Read only property 
    public string Ime { get; }
    // Read only property 
    public string Lozinka { get; }
   
    // Konstruktor
    public Korisnik(string ime, string lozinka)
    {
        Ime = ime;
        this.Lozinka = lozinka;
    }
}