using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Text;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack) osvjezi();
    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        osvjezi();
    }

    //Dohvati filmove pomoću ADO.NET-a
    private void osvjezi()
    {
        //Tu su svi parametri za povezivanje
        string connString = WebConfigurationManager.ConnectionStrings["Filmovi"].ConnectionString;
        SqlConnection connection = new SqlConnection();
        connection.ConnectionString = connString; //sad se možemo spojiti
        //SAd pripremi text SQL-a za slanje prema bazi
        SqlCommand command = new SqlCommand();
        command.CommandType = System.Data.CommandType.Text; //ovo je bio i defaultni izbor
        command.CommandText = "SELECT * FROM Film";
        command.Connection = connection;
        try
        {
            connection.Open();
            //Sad konačno možemo pročitati podatke
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows) //ako ima nešto kreiraj tablicu
            {
                //Kreiraj HTML tablicu koristi builder da bude brže
                StringBuilder sb = new StringBuilder();
                sb.Append("<table><tr><th>ID</th><th>Naziv</th><th>Država</th></tr>");
                // sada čitati iz datareader-a, red po red
                while (reader.Read())
                {
                    sb.Append("<tr><td>");
                    sb.Append(reader[0].ToString()); //prvi element ili ID
                    sb.Append("</td><td>");
                    sb.Append(reader[1].ToString()); //Naziv, moramo po indeksu
                    sb.Append("</td><td>");
                    sb.Append(reader[2].ToString()); // Država
                    sb.Append("</td></tr>");
                }
                //Upiši tablicu u DIV
                filmovi.InnerHtml = sb.ToString();
            }
        }
        catch (Exception ex)
        {
            //Kaži u čemu je problem
            lb_greska.Text = ex.Message.ToString();

        }
        finally
        {
            //Šta god da je bilo ti zatvori vezu prema bazi
            connection.Close();
        }

    }

    protected void LinkButton2_Click(object sender, EventArgs e)
    {
        //Tu su svi parametri za povezivanje
        string connString = WebConfigurationManager.ConnectionStrings["Filmovi"].ConnectionString;
        SqlConnection connection = new SqlConnection(connString);
        SqlCommand command = new SqlCommand("INSERT INTO Film VALUES(@Naziv, @Drzava)", connection); //ovo je kraće
        command.Parameters.AddWithValue("Naziv", tb_naziv.Text);
        command.Parameters.AddWithValue("Drzava", tb_drzava.Text);
        try
        {
            connection.Open();
            //Sad možemo izvršiti i unos
            int nrRows = command.ExecuteNonQuery(); //Izvrši insert i vrati koliko je novih redova
            if(nrRows == 1) //Nije tako bitmo kao kod update/delete ali trebao bi biti jedan novi red
            {
                osvjezi();
            } else
            {
                lb_greska.Text = "Nije unesen jedan red?!";
            }

        }
        catch (Exception ex)
        {
            //Kaži u čemu je problem
            lb_greska.Text = ex.Message.ToString();

        }
        finally
        {
            //Šta god da je bilo ti zatvori vezu prema bazi
            connection.Close();
        }

    }
}