using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;

public partial class Studenti : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        // Spoji se na Bazu i daj GV-u podatke
        // Treba mi CS
        string connetionString = WebConfigurationManager
            .ConnectionStrings["StudentiConnectionString"]
            .ConnectionString;
        // Ovo je objekt koji se spaja na bazu
        SqlConnection connection = new SqlConnection(connetionString);
        // Treba nam SQL za poslati
        SqlCommand command = new SqlCommand();
        // Koristi ovu konekciju
        command.Connection = connection;
        command.CommandText = "SELECT * FROM student";
        command.CommandType = System.Data.CommandType.Text;

        try
        {
            // Otvori vezu prema bazi
            connection.Open();
            // Pročitaj iz baze i vrati Čitač
            SqlDataReader reader = command.ExecuteReader();
            // Tvoj izvor je ovaj čitač
            gv_studenti.DataSource = reader;
            // Prikaži ovo u gridu
            gv_studenti.DataBind();
        }
        catch (SqlException ex)
        {
            // Izvrši obradu greške
        } finally
        {
            connection.Close();
        }

    }
}