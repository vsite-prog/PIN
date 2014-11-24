using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Global
/// </summary>
public static class Global
{
    public static string tajna = "I nije tajna sve stranice me vide...";

    // Lista korisnika koji pripadaju site
    public static Korisnik[] sviKorisnici = new Korisnik[] {
            new Korisnik("ja", "Moje Ime", "ja1"),
            new Korisnik("ana", "Ana Anić", "ana1"),
            new Korisnik("mate", "Mate Anić", "mate1")
    };

    public static Korisnik imaLiKorisnika (string pIme, string pLozinka){

        //Pregledaj sve korisnike
        for (int i = 0; i < sviKorisnici.Length; i++)
        {   //provjeri prijavu
            if (sviKorisnici[i].Ime == pIme && sviKorisnici[i].Lozinka == pLozinka)
                return sviKorisnici[i];
        }
        return null;
    }
}