using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Studenti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Spoji se na bazu
        // Čitam string za konekciju iz webconfig
        string connStr = WebConfigurationManager
            .ConnectionStrings["KonekcijskiTekst"]
            .ConnectionString;
        // Sada mi treba konekcijski objekt sa podacima za konekciju
        SqlConnection connection = new SqlConnection(connStr);
        // Treba pripremiti SQL Upit
        SqlCommand command = new SqlCommand();
        command.Connection = connection; // spoji se preko naše konekcije
        command.CommandText = "SELECT Ime, Prezime, Grad from Student"; // Naš SQL
        command.CommandType = CommandType.Text;
        // Otvoriti vezu prema DB
        connection.Open();
        // Sada ako smo ovdje imamo vezu prema bazi
        SqlDataReader reader = command.ExecuteReader(); // Izvedi SELECT i spremi podatke u buffer
        // Prikaži podatke
        gv_studenti.DataSource = reader;
        // Sada ih stvarno prikaži
        gv_studenti.DataBind();
        // Zatvori konekcije
        connection.Close();

    }
}