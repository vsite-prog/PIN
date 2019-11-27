using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        prikazi_korisnike();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        // Hashiraj lozinku
        string hashLozinka = KriptoKlasa.Kriptiraj(tb_lozinka.Text);
        // Zbog duginih tablica
        Random generator = new Random(DateTime.Now.Millisecond);
        string sol = generator.Next().ToString();
        string konacnaLozinka = KriptoKlasa.Kriptiraj(hashLozinka + sol);


        string povezniTekst = WebConfigurationManager
            .ConnectionStrings["KorisniciConnectionString"]
            .ConnectionString;
        SqlConnection konekcija = new SqlConnection(povezniTekst);
        SqlCommand komanda = new SqlCommand();
        // Konekcija i tekst naredbe
        komanda.Connection = konekcija;
        komanda.CommandText = "INSERT INTO Korisnik(kime, lozinka, punoIme, sol) VALUES(@kime, @lozinka, @punoIme, @sol)";
        // Idemo sada upisati parametre
        komanda.Parameters.AddWithValue("kime", tb_kime.Text);
        komanda.Parameters.AddWithValue("lozinka", konacnaLozinka);
        komanda.Parameters.AddWithValue("punoIme", tb_ime.Text);
        komanda.Parameters.AddWithValue("sol", sol);
        // Idemo unijeti novi red
        try
        {
            konekcija.Open();
            // Izvrši promjenu i vrati koliko je redova
            int brojRedova = komanda.ExecuteNonQuery();
            if (brojRedova == 1)
            {
                lb_poruka.Text = "Uspešno uneseno!";
            } else
            {
                lb_poruka.Text = "Nije uspjelo!";
            }
        } catch (SqlException ex)
        {
            lb_poruka.Text = "Greška: " + ex.Message;
        } finally
        {
            konekcija.Close();
        }
        prikazi_korisnike();
    }

    void prikazi_korisnike()
    {
        string povezniTekst = WebConfigurationManager
            .ConnectionStrings["KorisniciConnectionString"]
            .ConnectionString;
        SqlConnection konekcija = new SqlConnection(povezniTekst);
        SqlCommand komanda = new SqlCommand("SELECT kime, lozinka, punoIme FROM Korisnik", konekcija);
        try
        {
            konekcija.Open();
            SqlDataReader citac = komanda.ExecuteReader();
            if (citac.HasRows) // Imamo li bar jedan red u bazi
            {
                korisniciDiv.InnerHtml = " <table><tr><td>Korisničko  Ime</td><td>Korisničk lozinka</td><td>Korisničko  puno ime</td></tr>";
                while (citac.Read()) // Kursor, on ide red po red
                {
                    //Ovako se čita iz readera [indeks ili naziv kolone]
                    korisniciDiv.InnerHtml += "<tr><td>" + citac[0] + "</td><td>" + citac["lozinka"] + "</td><td>" + citac["punoIme"] + "</td></tr>";
                }
                korisniciDiv.InnerHtml += "</table>";
            } else
            {
                lb_poruka.Text = "Nema korisnika";
            }
        }
        catch (SqlException ex)
        {
            lb_poruka.Text = "Greška: " + ex.Message;
        }
        finally
        {
            konekcija.Close();
        }

        // Ima i lakši način a to je sql adapter + dataset + gridview
        SqlDataAdapter uticnica = new SqlDataAdapter("SELECT * FROM Korisnik", konekcija);
        DataSet setPodataka = new DataSet(); // Novi izvor podataka
        uticnica.Fill(setPodataka);
        gv_korisnici.DataSource = setPodataka;
        gv_korisnici.DataBind(); //Sad se prikazuju podaci
        
    }
}