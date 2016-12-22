using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Prijava : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Prijavi korisnika
        //Vidi prošla predavanja opet se spajamo na bazu
        string cstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["Korisnici"].ConnectionString;
        SqlConnection conn = new SqlConnection(cstr);
        SqlCommand comm = new SqlCommand("SELECT  punoIme, lozinka, sol FROM Korisnik WHERE ime = @ime", conn);
        comm.Parameters.AddWithValue("ime", tb_ime.Text);
        try
        {
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read()) //Ako ima record sve super ako ne krivo KIMe
            {
                //Pročitaj podatke iz SELECT-a
                string punoIme = dr["punoIme"].ToString();
                string lozinka = dr["lozinka"].ToString();
                string sol = dr["sol"].ToString();
                 //Kriptiraj lozinku
                string unesenaLozinka = Util.KriptirajMe(tb_lozinka.Text);
                //Ponovo kriptiraj sa solju
                unesenaLozinka = Util.KriptirajMe(unesenaLozinka + sol);
                if (lozinka == unesenaLozinka) //provjeri da li su lozinke iste (kriptirane)
                {
                    Session["korisnik"] = punoIme;
                    Response.Redirect("Zastita.aspx");
                }
                else
                {
                    lb_greska.Text = "Kriva lozinka!";
                }
            }
            else
            {
                lb_greska.Text = "Nema tog korisnika";
            }

        }
        catch (Exception ex)
        {
            //Prikaži grešku
            lb_greska.Text = ex.Message.ToString();
        }
        finally
        {
            conn.Close();
        }

    }
}