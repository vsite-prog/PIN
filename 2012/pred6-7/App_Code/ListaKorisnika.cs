using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ListaKorisnika
/// </summary>
public static class ListaKorisnika
{
    private static List<Korisnik> svi;

    static ListaKorisnika()
    {
        svi = new List<Korisnik>();
        svi.Add(new Korisnik("marko", "marko", "Marko Marić"));
        svi.Add(new Korisnik("ana", "ana", "Ana Anić"));
        svi.Add(new Korisnik("ivica", "ivica", "Ivica Ivić"));
        //
        // TODO: Add constructor logic here		//
    }

    public static Korisnik nadjiKorisnika(string ime, string lozinka)
    {
        foreach (Korisnik kor in svi)
            if (kor.Kime == ime && kor.Lozinka == lozinka)
                return kor;

        return null;



    }
}