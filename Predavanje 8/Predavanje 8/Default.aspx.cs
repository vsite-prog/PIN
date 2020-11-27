using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Data;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            prikazi_korisnike2();
        }
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        // prije unosa treba zaštiti lozinku
        string hashLozinka = Kripto.Hashiraj(tb_lozinka.Text);
        // Malo ćemo zasoliti, za to nam trebaju slučajni znakovi
        Random random = new Random(DateTime.Now.Millisecond); // Generator slučajnih brojeva
        string sol = random.Next().ToString(); // slučajan tekst

        string hashSlanaLozinka = Kripto.Hashiraj(hashLozinka + sol); // Ovdje ne pomažu ni dugine tablice


        // Unijeti novog korisnika
        string connStr = WebConfigurationManager // Čitamp iz web config-a
            .ConnectionStrings["BazaTekst"]
            .ConnectionString;
        // Idemo stvoriti konekciju
        SqlConnection conn = new SqlConnection(connStr);
        // Idemo formulirati SQL za unos podataka
        SqlCommand command = new SqlCommand();
        command.Connection = conn;
        command.CommandType = CommandType.Text; // Vidi gore using Sys.data
        command.CommandText = "INSERT INTO Korisnici(Kime, Lozinka, Pime, Unesen, Sol) VALUES(@kime, @lozinka, @pime, @uneseno, @sol)"; // @ označava parametar
        command.Parameters.AddWithValue("kime", tb_kime.Text); // Dodajte vrijednosti parametara
        command.Parameters.AddWithValue("lozinka", hashSlanaLozinka );
        command.Parameters.AddWithValue("pime", tb_pime.Text);
        command.Parameters.AddWithValue("uneseno", DateTime.Now);
        command.Parameters.AddWithValue("sol", sol);
        // Možemo krenuti sa unosom
        try
        {
            conn.Open(); // Ako konekcija nije otvorena ne možemo izvršiti komandu
            int noviRedovi = command.ExecuteNonQuery(); // Nema povratnih podataka
            if (noviRedovi == 1)
                lb_poruka.Text = "Unesen korisnik!";
            else
                lb_poruka.Text = "???";
            prikazi_korisnike();
        } catch (Exception ex)
        {
            lb_poruka.Text = "Greškaaa!!!";
        } finally
        {
            conn.Close(); // Obvezno zatvaranje konekcije
        }
    }

    void prikazi_korisnike()
    {
        // Čitaj iz baze i generiraj HTML stranicu
        // Unijeti novog korisnika
        string connStr = WebConfigurationManager // Čitamp iz web config-a
            .ConnectionStrings["BazaTekst"]
            .ConnectionString;
        // Idemo stvoriti konekciju
        SqlConnection conn = new SqlConnection(connStr);
        // Idemo formulirati SQL za unos podataka
        SqlCommand command = new SqlCommand();
        command.Connection = conn;
        command.CommandType = CommandType.Text; // Vidi gore using Sys.data
        command.CommandText = "SELECT Kime, Lozinka, Pime, Unesen FROM Korisnici";
        try
        {
            conn.Open(); // Ako konekcija nije otvorena ne možemo izvršiti komandu
            SqlDataReader reader = command.ExecuteReader() ; // nAŠ ČITAČ KOJI JE Buffer podataka
            string tablica = "<table><tr><th>Korisničko ime</th><th>Lozinka</th><th>Puno ime</th><th>Datum unosa</th></tr>";
            // Ima li redova u našem readeru
            if (reader.HasRows)
            {
                while (reader.Read()) // next, makni se na idući red sve do kraja
                {
                    tablica += "<tr>";
                    tablica += "<td>" + reader[0] + "</td>"; // reader[0] -- pročitaj prvu ćeliju 
                    tablica += "<td>" + reader["Lozinka"] + "</td>";
                    tablica += "<td>" + reader["Pime"] + "</td>";
                    tablica += "<td>" + reader["Unesen"] + "</td>";
                    tablica += "</tr>";
                }
            }
            tablica += "</table>";

            korisnici.InnerHtml = tablica;
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

    void prikazi_korisnike2()
    {
        // Čitaj iz baze na jednostavnji način
        string connStr = WebConfigurationManager // Čitamp iz web config-a
            .ConnectionStrings["BazaTekst"]
            .ConnectionString;
        // Idemo stvoriti konekciju
        SqlConnection conn = new SqlConnection(connStr);
        // Umjesto readere-a idemo koristiti dataset
        // treba mi data adapter
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Korisnici", conn);
        DataSet dataSet = new DataSet(); // Spremnik podataka
        adapter.Fill(dataSet); // Evo podaci su učitani u DS

        gv_korisnici.DataSource = dataSet;
        // Prikaži podatke
        gv_korisnici.DataBind();
    }
        
  }