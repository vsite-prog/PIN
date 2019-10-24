using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (!IsPostBack)
        {
            prikaziKorisnike();
        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //HAshiraj lozinku
        string sol = DateTime.Now.Millisecond.ToString() + "sol";
        // Prvi hash
        string lozinka = Kripto.Hash(tb_lozinka.Text + sol);
        // Još jedan hash
        lozinka = Kripto.Hash(lozinka + sol);

        // Kako ćemo unijeti korisnika
        // Copy paste
        //Čitaj iz web configa
        string connectionString = WebConfigurationManager.ConnectionStrings["BazaCS"].ConnectionString;
        // Kreiraj konekciju na Bazu preko connection stringa
        SqlConnection connection = new SqlConnection(connectionString);
        // Sad kreiraj komandu
        SqlCommand command = new SqlCommand();
        // daj konekciju
        command.Connection = connection;
        // SQL koji ćemo izvesti, sada uvodimo parametre u priču (placeholder)
        command.CommandText = "INSERT INTO Korisnik VALUES (@ime, @lozinka, @sol)";
        // Idemo sada zamijeniti parametre s vrijdnostima
        command.Parameters.AddWithValue("ime", tb_ime.Text);
         // Hashirana lozinka
        command.Parameters.AddWithValue("lozinka", lozinka );
        // I njena sol
        command.Parameters.AddWithValue("sol", sol);
        // koja vrsta komande
        command.CommandType = System.Data.CommandType.Text;
        // opet otvori konekciju i izvrši SQL
        try
        {
            // poveži se
            connection.Open();
            // Non query je upit koji ne očekuje podatke, već ih mijenja
            int kolikoRedova = command.ExecuteNonQuery(); // vraća broj promijenjenih redova
            // Morao bi kreirati samo jedan red
            if (kolikoRedova != 1)
                throw new Exception("Nije dobro ");
            else
                prikaziKorisnike();
        }
        catch (SqlException ex)
        {
            // Nešto napravi
        }
        finally // on se uvijek izvodi
        {
            // Zatvori konekciju
            connection.Close();
        }
    }
    void prikaziKorisnike()
    {
        //Čitaj iz web configa
        string connectionString = WebConfigurationManager.ConnectionStrings["BazaCS"].ConnectionString;
        // Kreiraj konekciju na Bazu preko connection stringa
        SqlConnection connection = new SqlConnection(connectionString);
        // Sad kreiraj komandu
        SqlCommand command = new SqlCommand();
        // daj konekciju
        command.Connection = connection;
        // SQL koji ćemo izvesti
        command.CommandText = "SELECT * FROM Korisnik";
        // koja vrsta komande
        command.CommandType = System.Data.CommandType.Text; // ovo smo mogli i preskočiti jer je default
        // idemo na bazu 
        try
        {
            // poveži se
            connection.Open();
            // Izvrši SQL i primi podatke
            SqlDataReader reader = command.ExecuteReader();

            // Idemo sada ručno čitati iz Data readera
            while (reader.Read()) // on pozicionira kursor na novi rekord i vraća true ako ga ima i false ako nema
            {
                // Tri način ačitanja iz data readera
                lb_korisnici.Text += reader[0] + " " + reader["ime"] + " " + reader.GetString(2) + "<br>";
            }

            // idemo ponovo demonstrirati kako bi se povezao
            reader.Close();
            reader = command.ExecuteReader();

            // Neka reader bude izvor podataka za naš gri view
            gv_korisnici.DataSource = reader;
            // ajde sad pročitaj podatke
            gv_korisnici.DataBind();

        }
        catch (SqlException ex)
        {
            // Nešto napravi
        }
        finally // on se uvijek izvodi
        {
            // Zatvori konekciju
            connection.Close();
        }
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        //Provjeri je li login dobar i ako je pošalji ga na drugu
        // Spoji se na bazu i vidi ima li korisnik s tim imenom
        //Čitaj iz web configa
        string connectionString = WebConfigurationManager.ConnectionStrings["BazaCS"].ConnectionString;
        // Kreiraj konekciju na Bazu preko connection stringa
        SqlConnection connection = new SqlConnection(connectionString);
        // Sad kreiraj komandu
        SqlCommand command = new SqlCommand();
        // daj konekciju
        command.Connection = connection;
        // SQL koji ćemo izvesti
        command.CommandText = "SELECT lozinka, sol FROM Korisnik WHERE ime = @ime";
        command.Parameters.AddWithValue("ime", tb_lime.Text);

        // idemo na bazu 
        try
        {
            // poveži se
            connection.Open();
            // Izvrši SQL i primi podatke
            SqlDataReader reader = command.ExecuteReader();

            if (!reader.HasRows)
            {
                // Kriv unos korisničkog imena, poruka o grešci
            }
            reader.Read();
            // daj mi lozinku i sol
            string lozinka = reader["lozinka"].ToString();
            string sol = reader["sol"].ToString();

            // Prvi hash
            string unesenaLozinka = Kripto.Hash(tb_llozinka.Text + sol);
            // Još jedan hash
            unesenaLozinka = Kripto.Hash(unesenaLozinka + sol);
            // samo za slučaj da su iste, idi dalje
            if (unesenaLozinka == lozinka)
            {
                Response.Redirect("Druga.aspx");
            }
        }
        catch (SqlException ex)
        {
            // Nešto napravi
        }
        finally // on se uvijek izvodi
        {
            // Zatvori konekciju
            connection.Close();
        }

 
    }
}