using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Osoba
/// </summary>
[Serializable]
public class Osoba
{
    public string Ime {get;set;}
    public string Prezime {get;set;}
	public Osoba()
	{
              
	}
    public Osoba (string ime, string prezime)
    {
        this.Ime = ime;
        this.Prezime = prezime;
    }

    public bool jeliIsta(Osoba o)
    {
        if (this.Ime == o.Ime && this.Prezime == o.Prezime)
            return true;

        return false;

    }
}