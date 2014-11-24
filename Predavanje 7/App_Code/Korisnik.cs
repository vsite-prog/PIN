using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Korisnik
/// </summary>
public class Korisnik
{
    private string naziv;

    //svojstva
    public string Ime { get; set; }
    public string Naziv
    {
        get { return naziv; }
        set { naziv = value; }
    }

    public string Lozinka { get; set; }


	public Korisnik(string pIme, string pNaziv, string pLozinka)
	{
        Ime = pIme;
        Naziv = pNaziv;
        Lozinka = pLozinka;
	}
}