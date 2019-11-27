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

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string povezniTekst = WebConfigurationManager
        .ConnectionStrings["KorisniciConnectionString"]
        .ConnectionString;
        SqlConnection konekcija = new SqlConnection(povezniTekst);
        SqlCommand komanda = new SqlCommand("SELECT lozinka, punoIme FROM Korisnik WHERE kime = @kime", konekcija);
        komanda.Parameters.AddWithValue("kime", tb_kime.Text);
        try
        {
            konekcija.Open();
            SqlDataReader citac = komanda.ExecuteReader();
            if (citac.Read()) // Imamo li bar jedan red u bazi
            {
                string spremljenaLozinka = citac["lozinka"].ToString();
                // Idemo usporediti da vidimo je li to taj korisik
                // Hashiraj lozinku
                string hashLozinka = KriptoKlasa.Kriptiraj(tb_lozinka.Text);
                string sol = citac["sol"].ToString();
                string unesenaLozinka = KriptoKlasa.Kriptiraj(hashLozinka + sol);
                // Provjeri je li lozinka ispravna
                if (unesenaLozinka == spremljenaLozinka)
                {
                    lb_poruka.Text = "Dobar dan : " + citac["punoIme"];
                } else
                {
                    lb_poruka.Text = "Kriva lozinka";
                }
            }
            else
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
    }
}