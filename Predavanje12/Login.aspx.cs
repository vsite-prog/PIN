using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlServerCe;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //sPOJI SE NA BAZU I pročitaj korisnika
        string connString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString;
        SqlCeConnection connection = new SqlCeConnection(connString);
        //kreiraj select komandu
        SqlCeCommand command = new SqlCeCommand();
        command.Connection = connection;
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = "SELECT lozinka, salt FROM korisnik WHERE kime = @ime";
        //Pročitaj lozinku i ime
        command.Parameters.AddWithValue("ime", tb_kime.Text);
        connection.Open();
        //Pročitaj podatke
        SqlCeDataReader reader = command.ExecuteReader();

        if (reader.Read())
        {
            // Bingo tu je korisnik, idemo vidjeti lozinku
            string lozinka = reader["lozinka"].ToString();
            string salt = reader["salt"].ToString();
            //hashiraj
            string hashLozinka = Util.hashHash(Util.hashHash(tb_lozinka.Text) + salt);
            if (hashLozinka == lozinka)
            {
                Session["korisnik"] = tb_kime.Text;
                Response.Redirect("LogiraniKorisnici.aspx");
            }
            else
            {
                lb_greska.Text = "Kriva lozinka";
            }

        }
        else
        {
            lb_greska.Text = "Nepostojeći korisnik";
        }
        //zatvaram
        connection.Close();
    }
}