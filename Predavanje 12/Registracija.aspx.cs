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

    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        //Vidi prošla predavanja opet se spajamo na bazu
        string cstr = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["Korisnici"].ConnectionString;
        SqlConnection conn = new SqlConnection(cstr);
        SqlCommand comm = new SqlCommand("INSERT INTO Korisnik VALUES (@ime, @punoIme, @lozinka, @sol)", conn);
        //Kriptiraj lozinku
        string lozinka = Util.KriptirajMe(tb_lozinka.Text);
        // Idemo soliti generiraj broj iz sadašnjeg vremena
        string sol = new Random(DateTime.Now.Millisecond)
            .Next()
            .ToString();
        //Ponovo kriptiraj sa solju
        lozinka = Util.KriptirajMe(lozinka + sol);
        //Dodaj parametre
        comm.Parameters.AddWithValue("ime", tb_ime.Text);
        comm.Parameters.AddWithValue("punoIme", tb_puno_ime.Text);
        comm.Parameters.AddWithValue("lozinka", lozinka);
        comm.Parameters.AddWithValue("sol", sol);
        try
        {
            conn.Open();
            if (comm.ExecuteNonQuery() == 1)//moramo unijeti samo jedan red
            {
                //Možda da ga logiramo?
            } else
            {
                lb_greska.Text = "Nije unesen jedan kor!";
            }

        } catch (Exception ex) {
            //Prikaži grešku
            lb_greska.Text = ex.Message.ToString();
        } finally
        {
            conn.Close();
        }
          
     
    }
}