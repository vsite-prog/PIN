using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Korisnik
/// </summary>
public class Korisnik
{ 
    public string Kime { get; set; }
    public string Lozinka { get; set; }
    public string PunoIme { get; set; }

	public Korisnik(string kime , string lozinka, string punoime)
	{
		//
		// TODO: Add constructor logic here
		//
        this.Kime = kime;
        this.Lozinka = lozinka;
        this.PunoIme = punoime;
	}
}