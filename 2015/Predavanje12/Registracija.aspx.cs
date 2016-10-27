using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

public partial class Registracija : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //Generate random integer for salt
        Random r = new Random(DateTime.Now.Millisecond);
        string sol = r.Next().ToString();
        //hash psw
        string hashLozinka = Util.hash(tb_lozinka.Text);
        //add salt and hash 
        string hashSlanaLozinka = Util.hash(hashLozinka + sol);
        string connStr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["BazaCS"].ConnectionString;
        SqlConnection conn = new SqlConnection(connStr);
        SqlCommand comm = new SqlCommand("INSERT INTO Korisnik VALUES (@kime, @lozinka, @sol, @punoime ) ", conn);
        comm.Parameters.AddWithValue("kime", tb_kime.Text);
        comm.Parameters.AddWithValue("lozinka", hashSlanaLozinka);
        comm.Parameters.AddWithValue("sol", sol);
        comm.Parameters.AddWithValue("punoime", tb_punoime.Text);
        try
        {
            conn.Open();
            int brojRedova = comm.ExecuteNonQuery();
            if (brojRedova == 1)
            {
                Session["ime"] = tb_punoime.Text;
                Response.Redirect("dobardan.aspx"); //Reserved users
            } //...
        }  finally
        {
            conn.Close();
        }
    }
}