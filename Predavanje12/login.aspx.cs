using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["BazaCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand comm = new SqlCommand("SELECT lozinka, sol, punoime FROM Korisnik WHERE kime = @kime", conn);
        comm.Parameters.AddWithValue("kime", tb_kime.Text);
        try
        {
            conn.Open();
            SqlDataReader dr = comm.ExecuteReader();
            if (dr.Read())
            {
                //REpeat hash procedure and see if psw fits
                string sol = dr["sol"].ToString();
                string spremljenaLozinka = dr["lozinka"].ToString();
                string hashLozinka = Util.hash(tb_lozinka.Text);
                //add salt and hash 
                string hashSlanaLozinka = Util.hash(hashLozinka + sol);
                if (spremljenaLozinka == hashSlanaLozinka)
                {
                    Session["ime"] = dr["punoime"].ToString();
                    Response.Redirect("dobardan.aspx"); //Reserved users
                }
                else
                {
                    label_greska.Text = "Nepostojeći korisnik!";
                }

            }

               
            //...
        }
        catch (Exception ex)
        {

        }
        finally
        {
            conn.Close();
        }
    }
}