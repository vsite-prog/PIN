using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlServerCe;
using System.Web.Configuration;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //citaj podatke za spajanje iz web.config
        string connStr = WebConfigurationManager.ConnectionStrings["BrodoviCS"].ConnectionString;
        //kreiraj objekt za spajanje na baze
        SqlCeConnection conn = new SqlCeConnection(connStr);
        SqlCeCommand cmd = new SqlCeCommand();
        cmd.Connection = conn;
        cmd.CommandType = System.Data.CommandType.Text;
        cmd.CommandText = "SELECT * FROM brodovi";
        try
        {
            conn.Open();
            SqlCeDataReader dr = cmd.ExecuteReader();
            //mogli smo i tablicu kreirati kao ASP.NET kontrolu
            brodovi.InnerHtml = "<table> <tr> <th>ID</th><th>Naziv</th><th>Luka</th><th>Godina</th></tr>";
            //inace ima dr.HasRows ...
            while (dr.Read())
            {
                //ljepše bi bilo sa String Builder
                brodovi.InnerHtml += "<tr><td>" + dr["id"].ToString() + "</td><td>" + dr["naziv"] + "</td><td>" + dr["luka"] + "</td><td>" + dr["godina"] + "</td><td></tr>";
            }
            brodovi.InnerHtml += "</table>";
        }
        catch (Exception ex)
        {
            //evidentiraj grešku
            lb_greska.ForeColor = System.Drawing.Color.Red;
            lb_greska.Text = "Neuspjelo čitanje" + ex.Message.ToString();
        }
        finally
        {
            //Zatvori konekciju
            conn.Close();
        }

    }
    protected void bt_spremi_Click(object sender, EventArgs e)
    {
        //citaj podatke za spajanje iz web.config
        string connStr = WebConfigurationManager.ConnectionStrings["BrodoviCS"].ConnectionString;
        //kreiraj objekt za spajanje na baze
        SqlCeConnection conn = new SqlCeConnection(connStr);
        SqlCeCommand cmd = new SqlCeCommand();
        cmd.Connection = conn;
        cmd.CommandType = System.Data.CommandType.Text;
        //Naredba sa prametrima, @ -radi SQL injection!!
        cmd.CommandText = "INSERT INTO brodovi(naziv, luka, godina) VALUES(@naziv, @luka, @godina)";
        //dodaj vrijednosti parametara
        cmd.Parameters.AddWithValue("@naziv", tb_naziv.Text );
        cmd.Parameters.AddWithValue("@luka", tb_luka.Text);
        //Dodati na drugi način 
        cmd.Parameters.Add("@godina", System.Data.SqlDbType.Int).Value = Int32.Parse( tb_godina.Text);
        try
        {
            conn.Open();
            //izvedi komandu
            int broj = cmd.ExecuteNonQuery();
            //Ukoliko je uspjelo daj neku poruku
            if (broj == 1 ){
                lb_greska.Text = "Unijeli ste novi brod!";
                lb_greska.ForeColor = System.Drawing.Color.Black;

            }
               
        }
        catch (Exception ex)
        {
            //evidentiraj grešku
            lb_greska.ForeColor = System.Drawing.Color.Red;
            lb_greska.Text = "Neuspio unos! <br>" + ex.Message.ToString();
        }
        finally
        {
            //Zatvori konekciju
            conn.Close();
        }


    }

}