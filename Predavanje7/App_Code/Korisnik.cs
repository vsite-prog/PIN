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
	
    public Korisnik(string pKime, string pLozinka, string pPuno)
	{
        Kime = pKime;
        Lozinka = pLozinka;
        PunoIme = pPuno;
	}
}