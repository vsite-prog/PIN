using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Prijava : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string connStr = WebConfigurationManager // Čitamp iz web config-a
           .ConnectionStrings["BazaTekst"]
           .ConnectionString;
        // Idemo stvoriti konekciju
        SqlConnection conn = new SqlConnection(connStr);
        // Idemo formulirati SQL za unos podataka
        SqlCommand command = new SqlCommand();
        command.Connection = conn;
        command.CommandType = CommandType.Text; // Vidi gore using Sys.data
        command.CommandText = "SELECT Lozinka, Pime, sol Unesen FROM Korisnici WHERE Kime = @kime";
        command.Parameters.AddWithValue("kime", tb_kime.Text);
        try
        {
            conn.Open(); // Ako konekcija nije otvorena ne možemo izvršiti komandu
            SqlDataReader reader = command.ExecuteReader(); // nAŠ ČITAČ KOJI JE Buffer podataka

            // Ima li redova u našem readeru
            if (reader.HasRows)
            {
                reader.Read(); // POzicioniranje na 1. red
                string spremljenaLozinka = reader["Lozinka"].ToString();
                string punoIme = reader["Pime"].ToString();
                string sol = reader[2].ToString(); // Koristimo index
                // Idemo provjeriti lozinku
                string hashLozinka = Kripto.Hashiraj(tb_lozinka.Text);
                // Malo ćemo zasoliti, za to nam trebaju slučajni znakovi
                string hashSlanaLozinka = Kripto.Hashiraj(hashLozinka + sol);
                // Da li je KOrisnik unio pravu lozinku tj. da li su hash-evi isti
                if(hashSlanaLozinka == spremljenaLozinka)
                    lb_poruka.Text = "Dobar dan: " + punoIme;
                else
                    lb_poruka.Text = "Kriva lozinka!";

            } else
            {
                lb_poruka.Text = "Korisnik nije pronađen";
            }

        }
        catch (Exception ex)
        {
            lb_poruka.Text = "Greškaa u čitanju!!!";
        }
        finally
        {
            conn.Close(); // Obvezno zatvaranje konekcije
        }
    }
}