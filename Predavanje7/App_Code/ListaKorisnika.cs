using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ListaKorisnika
/// </summary>
public static class ListaKorisnika
{
    static List<Korisnik> sviKorisnici;
	static ListaKorisnika()
	{
        sviKorisnici = new List<Korisnik>();
        sviKorisnici.Add(new Korisnik("ivo", "ivo1", "Ivo Ivić"));
        sviKorisnici.Add(new Korisnik("maja", "maja1", "Maja Majić"));
        sviKorisnici.Add(new Korisnik("ana", "ana1", "Ana Anić"));
	}

    public static Korisnik nadjiKorisnika(string pKime, string pLozinka){
        foreach (Korisnik kor in sviKorisnici)
            if (kor.Kime == pKime && kor.Lozinka == pLozinka)
                return kor;

        return null;
        
    }
}