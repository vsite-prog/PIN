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
        command.CommandText = "INSERT INTO Korisnik VALUES (@ime, @lozinka)";
        // Idemo sada zamijeniti parametre s vrijdnostima
        command.Parameters.AddWithValue("ime", tb_ime.Text);
        command.Parameters.AddWithValue("lozinka", tb_lozinka.Text);
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
}