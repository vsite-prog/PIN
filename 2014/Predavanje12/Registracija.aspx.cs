using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlServerCe;

public partial class Registracija : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {

        //Hash lozinke i salt
        string hashLozinka = Util.hashHash(tb_lozinka.Text);
        //Sol generiraj
        string salt = (new Random(DateTime.Now.Millisecond))
                       .Next()
                       .ToString();
        //hashiraj sve skupa
        string konacniHash = Util.hashHash(hashLozinka + salt);



        //sPOJI SE NA BAZU I spremi korisnika
        string connString = WebConfigurationManager.ConnectionStrings["UsersConnectionString"].ConnectionString;
        SqlCeConnection connection = new SqlCeConnection(connString);
        //kreiraj insert komandu
        SqlCeCommand command = new SqlCeCommand();
        command.Connection = connection;
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = "INSERT INTO korisnik VALUES(@ime, @lozinka, @salt)";
        //Pročitaj lozinku i ime
        command.Parameters.AddWithValue("ime", tb_kime.Text);
        // No No command.Parameters.AddWithValue("lozinka", tb_lozinka.Text);
        command.Parameters.AddWithValue("lozinka", konacniHash);
        command.Parameters.AddWithValue("salt", salt);
        connection.Open();
        int brojRedova = command.ExecuteNonQuery();
        connection.Close();
        if (brojRedova == 1)
        {
            //Logiraj korisnika
            Session["korisnik"] = tb_kime.Text;
            Response.Redirect("LogiraniKorisnici.aspx");
        } //else labela greška, itd...



    }
}