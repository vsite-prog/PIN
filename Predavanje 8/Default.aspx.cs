using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            prikazi(); //Prikaži POdatke

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Idemo čitati iz web configa
        string cstr = ConfigurationManager.ConnectionStrings["KorisnikCS"].ConnectionString;
        //Prikaži podatke u GV
        SqlConnection connection = new SqlConnection(cstr); //treba mi Connection String
        //Sad idemo napraviti komandu
        SqlCommand command = new SqlCommand();
        command.Connection = connection;

        //Idemo hashirati lozinku prije spremanja
        string hashLozinka = Util.Kriptiraj(tb_lozinka.Text);
        //Želimo i sol
        Random generator = new Random(DateTime.Now.Millisecond); //pokreni generator
        string sol = generator.Next().ToString();
        string hashSlanaLozinka = Util.Kriptiraj( hashLozinka + sol);


        command.CommandText = "INSERT INTO Korisnik VALUES (@kime, @lozinka, @pime, @sol)";
        command.Parameters.AddWithValue("kime", tb_kime.Text); //Dodaj novi parametar i odmah stavi vrijednost
        command.Parameters.AddWithValue("lozinka", hashSlanaLozinka); //Ovdje ide hash vrijednost
        command.Parameters.AddWithValue("pime", tb_pime.Text);
        command.Parameters.AddWithValue("sol", sol); //Sol ne treba hashirati
        try
        {
            //Otvori konekciju inače će biti greška
            //Bilo bi ljepše ovo izvoditi asinhrono
            connection.Open();
            int brojRedova = command.ExecuteNonQuery();
            if (brojRedova == 1) //Ako ne trebalo bi dati grešku...
            {
                prikazi(); //Moglo bi se ovo sve optimizirati
            }

        }
        catch (SqlException ex)
        {
            //Prikaži nekakvu grešku
        }
        finally
        {
            //U svakom slučaju zatvori konekciju
            connection.Close();
        }
    }
    void prikazi()
    {
        //Idemo čitati iz web configa
        string cstr = ConfigurationManager.ConnectionStrings["KorisnikCS"].ConnectionString;
        //Prikaži podatke u GV
        SqlConnection connection = new SqlConnection(cstr); //treba mi Connection String
        //Sad idemo napraviti komandu
        SqlCommand command = new SqlCommand();
        command.CommandText = "SELECT * FROM Korisnik";
        command.Connection = connection;
        try
        {
            //Otvori konekciju inače će biti greška
            //Bilo bi ljepše ovo izvoditi asinhrono
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            //Sada bi mogli ići while (reader.Read())
            //Koristimo binding
            gv_korisnici.DataSource = reader;
            //Refreshaj podatke
            gv_korisnici.DataBind();
        }
        catch (SqlException ex)
        {
            //Prikaži nekakvu grešku
        }
        finally
        {
            //U svakom slučaju zatvori konekciju
            connection.Close();
        }
    }
}