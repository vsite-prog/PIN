using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlServerCe;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string html = "<table><thead><tr><th>ID</th><th>Naziv</th><th>Vrsta</th></tr></thead><tbody>";
        //Pročitaj iz web.config-a
        string connString = WebConfigurationManager
            .ConnectionStrings["ZivotinjeConnectionString"]
            .ConnectionString;
        //Nova konekcija - objekt
        SqlCeConnection conn = new SqlCeConnection();
        //podaci za konekciju 
        conn.ConnectionString = connString;
        //SAd treba SQL, prvo command objekt
        SqlCeCommand command = new SqlCeCommand();
        //Tekst SQL naredbe
        command.CommandText = "SELECT * FROM zivotinje";
        //Mi dajemo SQL
        command.CommandType = System.Data.CommandType.Text;
        //Evo i konekcije, zaboravili...
        command.Connection = conn;
        try
        {
            //POKUŠAJ OTVORITI
            conn.Open();
            //treba izvršiti komandu i prihvatiti podatke
            SqlCeDataReader reader = command.ExecuteReader();
            //Čitaj red po red
            while (reader.Read())
            {
                //upiši novi red u HTML tablicu
                html += "<tr><td>" + reader["id"].ToString() + "</td><td>" 
                    + reader["naziv"] + "</td><td>" 
                    + reader["vrsta"] + "</td></tr>";
            }

        }
        catch (Exception ex)
        {
            lb_greska.Text = "Greška: " + ex.Message;
        }
        finally
        {
            //obvezno zatvoriti
            conn.Close();
        }

        
        html += "</tbody></table>";
        tableDiv.InnerHtml = html;
    }
}